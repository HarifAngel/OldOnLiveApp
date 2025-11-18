using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLive1
{
    class DbfbVentas
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=fbVentas";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddProducto(Productos prd)
        {
            string sql = "INSERT INTO producto_table VALUES (NULL, @Nombre, @Precio, @Live, NULL, @Pagado, @IDCliente)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = prd.Producto;
            cmd.Parameters.Add("@Precio", MySqlDbType.VarChar).Value = prd.Precio;
            cmd.Parameters.Add("@Live", MySqlDbType.VarChar).Value = prd.Live;
            cmd.Parameters.Add("@Pagado", MySqlDbType.Int16).Value = prd.Pagado;
            cmd.Parameters.Add("@IDCliente", MySqlDbType.VarChar).Value = prd.IDCliente;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Producto no agregado. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void AddCliente(Cliente clnt)
        {
            string sql = "INSERT INTO cliente_table VALUES (NULL, @ClienteName, NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClienteName", MySqlDbType.VarChar).Value = clnt.Nombre;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Agregado Exitosamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Cliente no agregado. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateProducto(Productos prd, string id)
        {
            string sql = "UPDATE producto_table SET Producto = @ProductosName, Precio = @ProductosPrecio, Live = @ProductosLive  WHERE ID = @ProductosID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductosID", MySqlDbType.Int64).Value = id;
            cmd.Parameters.Add("@ProductosName", MySqlDbType.VarChar).Value = prd.Producto;
            cmd.Parameters.Add("@ProductosPrecio", MySqlDbType.Int64).Value = prd.Precio;
            cmd.Parameters.Add("@ProductosLive", MySqlDbType.Int64).Value = prd.Live;
          
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Actualizado Exitosamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Producto no Actualizado. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateCliente(Cliente clnt, string id)
        {
            string sql = "UPDATE cliente_table SET Nombre = @ClienteName WHERE ID = @ClienteID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClienteID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ClienteName", MySqlDbType.VarChar).Value = clnt.Nombre;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modificado Exitosamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cliente no modificado. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdatePagarProducto(string id, string pagado)
        {
            string sql = "UPDATE producto_table SET Pagado = @ProductoPagado WHERE ID = @ProductoID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductoPagado", MySqlDbType.VarChar).Value = pagado;
            cmd.Parameters.Add("@ProductoID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Producto no Modificado. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteProducto(string id)
        {
            string sql = "DELETE FROM producto_table WHERE ID = @ProductosID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductosID", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Eliminado Exitosamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Producto no Eliminado. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteCliente(string id)
        {
            string sql = "DELETE FROM cliente_table WHERE ID = @ClienteID";
            string sql2 = "DELETE FROM producto_table WHERE IDCliente = @ClienteID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlCommand cmd2 = new MySqlCommand(sql2, con);
            cmd.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClienteID", MySqlDbType.VarChar).Value = id;
            cmd2.Parameters.Add("@ClienteID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Eliminado Exitosamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cliente no eliminado. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        public static void DisplayProductosCliente(string id, DataGridView dgv)
        {
            string sql = "SELECT ID, Producto, Precio, Live, Pagado FROM Producto_table WHERE IDCLiente = @ClienteID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClienteID", MySqlDbType.VarChar).Value = id;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void DisplayProductosClienteSum(string id, DataGridView dgv)
        {
            string sql = "SELECT SUM(Precio) FROM Producto_table WHERE IDCLiente = @ClienteID AND Pagado = 0";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClienteID", MySqlDbType.VarChar).Value = id;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}

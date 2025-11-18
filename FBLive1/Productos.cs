using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLive1
{
    internal class Productos
    {
        public string Producto { get; set; }

        public string Precio { get; set; }

        public string Live { get; set; }

        public int Pagado { get; set; } = 0;

        public string IDCliente { get; set; }

        public Productos(string producto, string precio, string live, int pagado, string iDCliente)
        {
            Producto = producto;
            Precio = precio;
            Live = live;
            Pagado = pagado;
            IDCliente = iDCliente;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class venta
    {

        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int idCliente { get; set; }
        public int idVendedor { get; set; }
        public int cantidadVenta { get; set; }
        public int valorVenta { get; set; }
        public DateTime FechaVenta { get; set; }

        public override string ToString()
        {
            return $"{idVenta};{idProducto};{idCliente};{idVendedor};{cantidadVenta};{valorVenta};{FechaVenta}";
        }
    }
}

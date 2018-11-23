using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class compra
    {
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public int idProovedor { get; set; }
        public int cantidadCompra { get; set; }
        public int valorCompra { get; set; }
        public DateTime fechaCompra { get; set; }

        public override string ToString()
        {
            return $"{idCompra};{idProducto};{idProovedor};{cantidadCompra}{valorCompra}";
        }
    }

}

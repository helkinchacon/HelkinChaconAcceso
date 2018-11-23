using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public int valorProducto { get; set; }
        public int cantidadProducto { get; set; }
        public override string ToString()
        {
            return $"{idProducto};{nombreProducto};{cantidadProducto};{valorProducto}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class cliente
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string cedulaCliente { get; set; }
        public string direccionCliente { get; set; }
        public string telefonoCliente { get; set; }

        public override string ToString()
            {
                return $"{idCliente};{nombreCliente};{apellidoCliente};{cedulaCliente};{direccionCliente}{telefonoCliente}";
            }
    }
}

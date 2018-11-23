using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class vendedor
    {
        public int idVendedor { get; set; }
        public string nombreVendedor { get; set; }
        public string apellidoVendedor { get; set; }
        public string cedulaVendedor { get; set; }

            public override string ToString()
            {
                return $"{idVendedor};{nombreVendedor};{apellidoVendedor};{cedulaVendedor}";
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class proovedor
    {
        public int idProovedor { get; set; }
        public string nombreProovedor { get; set; }
        public string direccionProovedor { get; set; }
        public string telefonoProovedor { get; set; }
        public string nitProovedor { get; set; }

        public override string ToString()
        {
            return $"{idProovedor};{nombreProovedor};{direccionProovedor};{telefonoProovedor};{nitProovedor}";
        }
    }
}

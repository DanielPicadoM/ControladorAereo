using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Aerolineas
    {
        public int IdAerolinea { get; set; }
        public string NombreAerolinea { get; set; }
        public string PaisOperacion { get; set; }
        public string CodigoIATA { get; set; }
        public string CodigoICAO { get; set; }
        public DateTime FechaFundacion { get; set; }
    }
}

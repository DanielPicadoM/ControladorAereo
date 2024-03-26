using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ComunicacionesControladorAeronave
    {
        public int ID { get; set; }
        public int ControladorID { get; set; }
        public int IdAeronave { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}

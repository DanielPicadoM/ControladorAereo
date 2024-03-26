using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Vuelos
    {
        public int IdVuelo { get; set; }
        public int IdAerolinea { get; set; }
        public int IdAeronave { get; set; }
        public int IdEstadoVuelo { get; set; }
        public int IdPiloto { get; set; }
        public string Ruta { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime Horallegada { get; set; }
        public int DuracionEstimada { get; set; }
    }
}

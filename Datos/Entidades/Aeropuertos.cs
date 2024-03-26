using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Aeropuertos
    {
        public int IdAeropuerto { get; set; }
        public int Nombre { get; set; }
        public int CiudadID { get; set; }
        public string Pais { get; set; }
        public string CodigoIATA { get; set; }
        public string CodigoICAO { get; set; }
        public int CapacidadAviones { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public string ZonaHoraria { get; set; }
    }
}

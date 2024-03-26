using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Aeronave
    {
        public int IdAeronave { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public int AnioFabricacion { get; set; }
        public string Matricula { get; set; }
        public int CapacidadPasajeros { get; set; }
        public Decimal CapacidadCarga { get; set; }
        public DateTime FechaUltimoMantenimiento { get; set; }
        public string TipoMotor { get; set; }
        public decimal Longitud { get; set; }
        public decimal Envergadura { get; set; }
        public decimal Altura { get; set; }
        public int IdEstadoAeronave { get; set; }
        public int CapacidadCombustible { get; set; }
        public decimal Alcance { get; set; }
        public int VelocidadMaxima { get; set; }
        public int AltitudMaxima { get; set; }
        public decimal PesoMaximoDespegue { get; set; }
        public int NumeroMotores { get; set; }
        public int Estado { get; set; }
        public int IdAerolinea { get; set; }

    }
}

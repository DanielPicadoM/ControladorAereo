using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InformacionMeteorologica
    {
        public int IdInformacionMeteorologica { get; set; }
        public int FechaHora { get; set; }
        public Decimal Temperatura { get; set; }
        public decimal VientoDireccion { get; set; }
        public decimal VientoVelocidad { get; set; }
        public decimal Visibilidad { get; set; }
        public decimal Precipitacion { get; set; }
    }
}

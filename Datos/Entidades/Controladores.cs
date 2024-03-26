using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Controladores
    {
        public int ID { get; set; }
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string TipoControlador { get; set; }
        public string Cargo { get; set; }
        public int IdAeropuerto { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string NivelCertificcion { get; set; }
        public string HorarioTrabajo { get; set; }
        public decimal Salario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    public class Atencion
    {
        public int NroAtencion { get; set; }
        public DateTime FechaAtencion { get; set; }
        public Enfermedad DatosEnfermedad { get; set; }
        public Persona DatosCliente { get; set; }

        
    }
}

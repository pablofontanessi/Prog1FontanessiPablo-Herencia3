using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    public class Persona
    {
        public String NombreYApellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public decimal IngresosNetosAnuales { get; set; }
        public Cobertura CoberturaSeleccionada { get; set; }

        public bool AccesoACobertura(Cobertura CoberturaNecesaria)
        {
            if (CoberturaNecesaria.CostoBaseCobertura <= IngresosNetosAnuales)
            {
                return true;
            }
            return false;
        }

    }
}

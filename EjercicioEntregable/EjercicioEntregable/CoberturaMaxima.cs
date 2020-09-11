using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    public class CoberturaMaxima: Cobertura
    {
        public override decimal CalcularCostoCobertura()
        {
            return CalcularCostosEnfermedadesCobertura();
        }
    }
}

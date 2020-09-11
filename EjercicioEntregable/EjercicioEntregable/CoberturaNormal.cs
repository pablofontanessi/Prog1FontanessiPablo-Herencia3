using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    public class CoberturaNormal : Cobertura
    {
        public override decimal CalcularCostoCobertura()
        {
            return CostoBaseCobertura + (CalcularCostosEnfermedadesCobertura()/EnfermedadesCubiertas.Count());
        }
    }
}

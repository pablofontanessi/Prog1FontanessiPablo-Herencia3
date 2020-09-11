using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    public abstract class Cobertura
    {
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int CantidadMaximaPersonas { get; set; }
        public decimal CostoBaseCobertura { get; set; }
        public List<Enfermedad> EnfermedadesCubiertas { get; set; }

        public abstract decimal CalcularCostoCobertura();
        public virtual decimal CalcularCostosEnfermedadesCobertura()
        {
            decimal CostoEnfermedades = 0;
            foreach (var enfermedad in EnfermedadesCubiertas)
            {
                CostoEnfermedades += enfermedad.CostoAsociado;
            }
            return CostoEnfermedades;
        }
        public bool ContieneEnfermedad(int CodigoEnfermedad)
        {
            foreach (var enfermedad in EnfermedadesCubiertas)
            {
                if (enfermedad.CodigoEnfermedad == CodigoEnfermedad)
                {
                    return true;
                }
            }
            return false;

        }

    }
}

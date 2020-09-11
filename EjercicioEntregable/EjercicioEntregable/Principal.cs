using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
   public class Principal
    {
        List<Enfermedad> ListaEnefermedades = new List<Enfermedad>();
        List<Persona> ListaPersonas = new List<Persona>();
        //List<Cobertura> ListaCobertura = new List<Cobertura>();
        List<Atencion> ListaAtencion = new List<Atencion>();

        public decimal RegistrarAtencion(DateTime FechaAtencion, int DniCliente, int CodigoEnfermedad )
        {
            foreach (var persona in ListaPersonas)
            {
                if (DniCliente == persona.DNI)
                {
                    if (persona.CoberturaSeleccionada.ContieneEnfermedad(CodigoEnfermedad))
                    {
                        Atencion NuevaAtencion = new Atencion();
                        NuevaAtencion.DatosCliente = persona;
                        foreach (var enfermedad in ListaEnefermedades)
                        {
                            if ( enfermedad.CodigoEnfermedad == CodigoEnfermedad)
                            {
                                NuevaAtencion.DatosEnfermedad = enfermedad;
                            }
                        }
                        NuevaAtencion.FechaAtencion = FechaAtencion;
                        NuevaAtencion.NroAtencion = ListaAtencion.Count() + 1;
                        Enfermedad EnfermedadOrigen = new Enfermedad();
                        foreach (var enfermedad in ListaEnefermedades)
                        {
                            if (enfermedad.CodigoEnfermedad == CodigoEnfermedad)
                            {
                                EnfermedadOrigen = enfermedad;
                            }
                        }
                        ListaAtencion.Add(NuevaAtencion);
                        return EnfermedadOrigen.CostoAsociado;
                       
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
                
            }
            return 0;
        }
    }
}

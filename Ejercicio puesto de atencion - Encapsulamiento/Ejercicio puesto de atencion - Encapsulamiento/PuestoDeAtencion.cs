using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Puesto { Caja1, Caja2 }
    public class PuestoDeAtencion
    {
        static int numeroActual;
        private Puesto puesto;

        public int NumeroActual { get { return numeroActual+1; }  }

        public bool Atender(Cliente c) 
        {
           if(c is not null) 
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
        static PuestoDeAtencion() 
        {
            numeroActual = 0;
        }
        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        

    }
}

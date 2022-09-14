using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoDeAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente { get { return this.clientes.Peek();} set {; } }

        private Negocio() 
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoDeAtencion(Puesto.Caja1);
        }
        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }
        public static bool operator !=(Negocio n, Cliente c) 
        {
            return !(n == c);
        }
        public static bool operator ==(Negocio n, Cliente c) 
        {
            foreach(Cliente item in n.clientes) 
            {
                if(item == c) 
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator +(Negocio n, Cliente c) 
        {
            if(n!= c) 
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator ~(Negocio n) 
        {
            if(n is not null && n.clientes.Count > 0)
            {
                n.caja.Atender(n.Cliente);
                n.clientes.Dequeue();
                return true;
              
            }
            return false;
        }

        public int ClientesPendientes { get { return this.clientes.Count; } }
    }
}

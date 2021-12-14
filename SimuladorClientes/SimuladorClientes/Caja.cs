using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorClientes
{
    public class Caja
    {
        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;

        public delegate void DelegadoClienteAtendido(Caja caja, string cliente);
        static Caja()
        {
          random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            this.clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public string NombreCaja { get {return this.nombreCaja; } }

        public int CantidadDeClientesALaEspera { get { return this.clientesALaEspera.Count(); } }

        internal void AgregarCliente(string unCliente)
        {
            clientesALaEspera.Enqueue(unCliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }

        private void AtenderClientes()
        {
            do
            {
                if (clientesALaEspera.Any())
                {
                    string cliente = clientesALaEspera.Dequeue();
                    delegadoClienteAtendido.Invoke(this, cliente);
                    Thread.Sleep(random.Next(1000, 5000));
                }
            } while (true);
        }
    }
}

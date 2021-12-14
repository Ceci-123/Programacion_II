using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SimuladorClientes;

namespace ConsoleClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja.DelegadoClienteAtendido delegadoClienteAtendido = (caja, cliente) =>
            {
                Console.WriteLine($"{DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja.");
            };



            Caja c1 = new Caja("caja1", delegadoClienteAtendido);
            Caja c2 = new Caja("caja2", delegadoClienteAtendido);
            List<Caja> listado = new List<Caja>()
            {
            c1,
            c2
            };

            Negocio nn = new Negocio(listado);
            Console.WriteLine("Asignando cajas..");
            
            List<Task> hilos = nn.ComenzarAtencion();
            Task.WaitAll(hilos.ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RelojTemporizador
{
    public class Temporizador
    {
        public CancellationToken cancellationToken;
        public CancellationTokenSource cancellationTokenSource;
        public Task hilo;
        public int intervalo;
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;

        public Temporizador(int milisegundos)
        {
            this.intervalo = milisegundos;
        }

        public bool EstaActivo { get {
                                       return hilo is not null &&
                                       (hilo.Status == TaskStatus.Running ||
                                       hilo.Status == TaskStatus.WaitingToRun ||
                                       hilo.Status == TaskStatus.WaitingForActivation);
            }  }

        public int Intervalo { get {return intervalo; }
                               set {this.intervalo = value; }
                              }

        private void CorrerTiempo()
        {
            do
            {
                if (TiempoCumplido is not null)
                {
                    TiempoCumplido.Invoke();
                }

                Thread.Sleep(intervalo);
            } while (!cancellationToken.IsCancellationRequested);
        }

        public void DetenerTemporizador()
        {
            if (hilo is not null && !hilo.IsCompleted)
            {
                cancellationTokenSource.Cancel();
            }
        }
        public void IniciarTemporizador()
        {
            if (hilo is null || hilo.IsCompleted)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;

                hilo = new Task(CorrerTiempo, cancellationToken);
            }
            if (!EstaActivo)
            {
               hilo.Start();

            }
        }
    }
}

using System;
using System.Text;

namespace CentralitaHerencia
{
   
    public class Llamada
    {
        public enum TipoLLamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get => duracion;  }
        public string NroDestino { get => nroDestino;  }
        public string NroOrigen { get => nroOrigen;  }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"DURACION: {this.Duracion}, NRO DESTINO: {this.NroDestino}, NRO ORIGEN: {this.NroOrigen}");
            return sb.ToString();

        }
    }
}

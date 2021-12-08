using System;
using System.Text;

namespace CentralitaHerencia
{
   
    public abstract class Llamada
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

        public abstract float CostoLlamada { get; }
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

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"DURACION: {this.Duracion}, NRO DESTINO: {this.NroDestino}, NRO ORIGEN: {this.NroOrigen}");
            return sb.ToString();

        }

        public abstract float CalcularCosto();

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if(l1.Equals(l2) && l1.NroDestino ==l2.NroDestino && l1.NroOrigen ==l2.NroOrigen)
            {
                retorno = true;
            }
            return retorno ;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 ==l2);
        }
    }
}

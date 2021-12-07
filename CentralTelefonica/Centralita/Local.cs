using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local :Llamada
    {
        protected float costo;

        public Local(Llamada llamada,float costo) :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string destino, float duracion, string origen, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada { get { return this.CalcularCosto(); }  }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} + COSTO: {this.CostoLlamada}");
            return sb.ToString();

        }
    }
}

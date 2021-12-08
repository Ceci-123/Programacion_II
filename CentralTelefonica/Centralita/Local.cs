using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local :Llamada
    {
        private float costo;

        public Local(Llamada llamada,float costo) :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string destino, float duracion, string origen, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada { get { return this.CalcularCosto(); }  }

        public override float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} + COSTO: {this.CostoLlamada}");
            return sb.ToString();

        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}

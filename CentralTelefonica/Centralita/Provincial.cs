using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial :Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;

        public float CostoLlamada { get { return this.CalcularCosto(); } }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} + COSTO: {this.CostoLlamada}");
            return sb.ToString();

        }

        private float CalcularCosto()
        {
            float retorno = 0;
           
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = this.Duracion*0.99F;
                    break;
                case Franja.Franja_2:
                    retorno = this.Duracion* 1.25F;
                    break;
                case Franja.Franja_3:
                    retorno = this.Duracion* 0.66F;
                    break;
            }
            return retorno;
        }
    }
}

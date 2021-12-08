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
        private Franja franjaHoraria;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()} + COSTO: {this.CostoLlamada} + FRANJA HORARIA: {this.franjaHoraria}");
            return sb.ToString();

        }

        public override float CalcularCosto()
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

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}

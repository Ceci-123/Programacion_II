using System;
using System.Text;

namespace Aduana
{
    public abstract class Paquete : IAduana
    {
        protected string codigoSeguimiento;
        protected decimal costoEnvio;
        protected string destino;
        protected string origen;
        protected double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"codigo de seguimiento: {codigoSeguimiento} costo envio: {costoEnvio} destino: {destino}");
            sb.Append($"origen: {origen} peso: {pesoKg} ");
            return sb.ToString();
        }

        public decimal Impuestos { get { return (costoEnvio * 35 / 100); } }

        public virtual decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos;
        }
        
    }
}

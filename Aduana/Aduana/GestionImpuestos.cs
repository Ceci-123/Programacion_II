using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduana
{
    public class GestionImpuestos
    {
        protected List<IAduana> impuestosAduana;
        protected List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal suma = 0;
            foreach (Paquete item in impuestosAduana)
            {
                suma += item.Impuestos;
            }
            return suma;
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            decimal suma = 0;
            foreach (Paquete item in impuestosAfip)
            {
                suma += item.Impuestos;
            }
            return suma;
        }
        public void RegistrarImpuestos(Paquete paquete)
        {
            impuestosAduana.Add(paquete);
            if(paquete is IAfip)
            {
                IAfip paqueteAfip = (IAfip)paquete;
                impuestosAfip.Add(paqueteAfip);
            }
        }
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                RegistrarImpuestos(item);
            }
        }
    }
}

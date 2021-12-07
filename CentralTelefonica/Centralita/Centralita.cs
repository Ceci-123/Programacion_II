using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        
        private List<Llamada> llamadas;
        protected string razonSocial;

        public Centralita(string nombreEmpresa) :base()
        {
            this.razonSocial = nombreEmpresa;
        }

        public Centralita()
        {
            this.llamadas = new List<Llamada>();
        }

        public List<Llamada> Llamadas { get { return llamadas; } }

        public float GananciasPorLocal { get {
                return CalcularGanancia(Llamada.TipoLLamada.Local);

            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLLamada.Todas); }
        }

        private float CalcularGanancia(Llamada.TipoLLamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada item in llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLLamada.Local:
                        if (item is Local)
                            ganancia += ((Local)item).CostoLlamada;
                        break;
                    case Llamada.TipoLLamada.Provincial:
                        if (item is Provincial)
                            ganancia += ((Provincial)item).CostoLlamada;
                        break;
                    case Llamada.TipoLLamada.Todas:
                        if (item is Local)
                            ganancia += ((Local)item).CostoLlamada;
                        else
                            ganancia += ((Provincial)item).CostoLlamada;
                        break;
                }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"RAZON SOCIAL: {this.razonSocial}, GANANCIA TOTAL: {this.GananciasPorTotal}, GANANCIA LOCAL: {this.GananciasPorLocal}, GANANCIA PROVINCIAL: {this.GananciasPorProvincial}");
            foreach (Llamada llamada in llamadas)
            {
                sb.AppendLine($"LLAMADA : {llamada.Mostrar()}");
            }
            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {
            llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}

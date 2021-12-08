using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        protected string rutaArchivo;

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
            
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        public string RutaDeArchivo
        {
            get
            {
                return this.rutaArchivo;
            }
            set
            {
                this.rutaArchivo = value;
            }
        }

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
            foreach (Llamada item in listaDeLlamadas)
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

        private string Mostrar()
        {
            int contador = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------listado de llamadas-----------");
            sb.Append($"RAZON SOCIAL: {this.razonSocial}, GANANCIA TOTAL: {this.GananciasPorTotal}, GANANCIA LOCAL: {this.GananciasPorLocal}, GANANCIA PROVINCIAL: {this.GananciasPorProvincial}");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine($"LLAMADA : {llamada.ToString()}");
                contador++;
            }
            sb.AppendLine($"cantidad de llamadas: {contador}");
            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(nuevaLlamada is not null)
            {
               this.listaDeLlamadas.Add(nuevaLlamada);

            }
        }

        public static bool operator ==(Centralita c, Llamada l1)
        {
            if (c is not null && l1 is not null)
            {
                foreach (Llamada item in c.listaDeLlamadas)
                {
                    if (item == l1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada l1)
        {
            return !(c == l1);
        }

        public static Centralita operator +(Centralita c, Llamada l1)
        {
            try
            {
                if (c != l1 && c is not null && l1 is not null)
                {
                    c.AgregarLlamada(l1);

                }
            }
            catch (Exception)
            {
                throw new CentralitaException("Llamada existente", "Centralita", "operator +");
            }
            
            return c;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public bool Guardar()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.RutaDeArchivo, true))
                {
                    sw.WriteLine(String.Format($"{DateTime.Now.ToString(new System.Globalization.CultureInfo("es-ES"))} - Se realizó una llamada"));
                }
            }
            catch (Exception ex)
            {
                throw new FallaLogException("error al guardar en archivo", ex);
            }

            return true;
        }

        public string Leer()
        {
            try
            {
                using (StreamReader rd = new StreamReader(this.RutaDeArchivo))
                {
                    return rd.ReadToEnd();
                }
            }
            catch
            {

                throw new FallaLogException("error al leer");
            }
        }
    }
}

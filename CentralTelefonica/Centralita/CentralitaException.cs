using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaException(string mensaje, string nombreClase, string nombreMetodo)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        public CentralitaException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException)
            :this(mensaje, nombreClase, nombreMetodo)
        {
           
        }

        protected string NombreClase { get => nombreClase;  }
        protected string NombreMetodo { get => nombreMetodo;  }
    }
}

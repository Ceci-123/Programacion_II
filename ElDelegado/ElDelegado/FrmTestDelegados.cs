using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDelegado
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegate(string nombre);
        private ActualizarNombreDelegate actualizarNombreDelegate;
        public FrmTestDelegados(ActualizarNombreDelegate actualizarNombreDelegate)
        {
            this.actualizarNombreDelegate = actualizarNombreDelegate;
            InitializeComponent();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarNombreDelegate.Invoke(txtNombre.Text);
        }
    }
}

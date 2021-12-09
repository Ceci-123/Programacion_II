using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaListaDelSuper
{
    public partial class FrmAltaModificacion : Form
    {
        public string Objeto { get { return txtObjeto.Text; } }
        public FrmAltaModificacion()
        {
            InitializeComponent();
        }

        public FrmAltaModificacion(string titulo, string objeto, string txtboton)
        {
            InitializeComponent();
            btnConfirmar.Text = txtboton;
            txtObjeto.Text = objeto;
            Text = titulo;
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void Confirmar()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("El texto no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

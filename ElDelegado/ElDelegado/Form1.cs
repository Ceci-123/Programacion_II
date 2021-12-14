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
    public partial class Form1 : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostrar.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("problema");
            }
            
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTestDelegados.Show();
                
                mostrarToolStripMenuItem.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("problema");
            }
            
        }
    }
}

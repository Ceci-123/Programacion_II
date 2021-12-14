using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojTemporizador
{
    public partial class Reloj : Form
    {
        private Temporizador temporizador;

        public Reloj()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.TiempoCumplido += AsignarHora;
            
        }
        public void AsignarHora()
        {
            if (lblHora.InvokeRequired)
            {
                Action delegadoAsignarHora = AsignarHora;
                lblHora.Invoke(delegadoAsignarHora);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }

        }

        private void FrmReloj_Load(object sender, EventArgs e)
        {
            
            ActualizarHoraConClaseTemporizador();
        }
        public void ActualizarHoraConClaseTemporizador()
        {
            temporizador.IniciarTemporizador();
        }
        

        private void btnDetenerReloj_Click_1(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }

        private void btnIniciarReloj_Click_1(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }
    }
}

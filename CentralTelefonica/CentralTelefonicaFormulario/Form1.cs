using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonicaFormulario
{
    public partial class Form1 : Form
    {
        Centralita c = new Centralita();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir modal el FrmLlamador
            FrmLlamador frm = new FrmLlamador(this.c);
            frm.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dg =  frm.ShowDialog();
            if(dg == DialogResult.OK)
            {
                //todo ok
                
            }
        }
    }
}

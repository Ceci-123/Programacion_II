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
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public Centralita Centralita
        {
            get { return this.centralita; }
        }
        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "Nro Destino";
            this.textBox2.Text = "Nro Origen";
            // Carga
            this.comboBox1.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(comboBox1.SelectedValue.ToString(), out franjas);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("9");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("8");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("7");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("2");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("1");
        }

        private void ImprimirNumero(string numero)
        {
            this.textBox2.Text += numero;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("*");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("0");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.ImprimirNumero("#");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //salir
        }
        private bool EsProvincial(Llamada unaLlamada)
        {
            return unaLlamada.NroDestino.StartsWith("#");
        }
    }
}

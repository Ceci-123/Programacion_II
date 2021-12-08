using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtrapameSiPuedes;

namespace Atrapame
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        float resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    throw new ParametrosVaciosException("estan vacios los cositos");
                }
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            try
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("debes escribir algo");
            }

            resultado = Calculador.Calcular(num1, num2);
            richTextBox1.Text = $"km/litros {resultado}" ;
        }
    }
}

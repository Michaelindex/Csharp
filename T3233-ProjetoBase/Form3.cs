using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3233_ProjetoBase
{
    public partial class Form03 : Form
    {
        public Form03()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variáveis
            double peso, altura, imc;

            // Entrada
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            // Processamento
            imc = peso / (altura * altura);

            // Saída
            txtIMC.Text = imc.ToString("N2");

            switch(imc)
            {
                case var _ when imc <= 18.5:
                    lblResultado.Text = "Magreza";
                    break;
                case var _ when imc > 18.5 && imc < 25:
                    lblResultado.Text = "Saudável";
                    break; 

            }
        }
    }
}

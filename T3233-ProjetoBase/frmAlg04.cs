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
    public partial class frmAlg04 : Form
    {
        public frmAlg04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // variáveis
            double peso, altura, imc;

            // entrada
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            // processamento
            imc = peso / (altura * altura);

            // saida
            txtIMC.Text = imc.ToString("N2");

            switch (imc)
            {
                case var _ when imc <= 18.5:
                    lblResultado.Text = "Magreza";
                    break;
                case var _ when imc > 18.5 && imc < 25:
                    lblResultado.Text = "Saudável";
                    break;
                case var _ when imc >= 25 && imc < 30:
                    lblResultado.Text = "SobrePeso";
                    break;
                case var _ when imc >= 30 && imc < 35:
                    lblResultado.Text = "Obesidade I";
                    break;
                case var _ when imc >= 35 && imc < 40:
                    lblResultado.Text = "Obesidade II";
                    break;
                case var _ when imc >= 40:
                    lblResultado.Text = "Obesidade III";
                    break;
            }
        }
    }
}

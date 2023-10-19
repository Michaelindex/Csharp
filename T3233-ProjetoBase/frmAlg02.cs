﻿using System;
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
    public partial class frmAlg02 : Form
    {
        public frmAlg02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variáveis
            double Kms, hrs, Vm;

            // Entrada
            Kms = double.Parse(txtKm.Text);
            hrs = double.Parse(txtHr.Text);

            // Processamento
            Vm = Kms / hrs;

            // Saída
            MessageBox.Show("A Velocidade Média é de " + Vm.ToString() + " Km/Hora",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}

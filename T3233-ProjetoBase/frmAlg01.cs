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
    public partial class frmAlg01 : Form
    {
        public frmAlg01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1, N2, N3, N4, Media;

            // Entrada
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            N3 = double.Parse(txtN3.Text);
            N4 = double.Parse(txtN4.Text);

            // Processamento
            Media = (N1 + N2 + N3 + N4) / 4;

            if (Media >= 7)
            {
                lblSituacao.ForeColor = Color.Blue;
                lblSituacao.Text = "APROVADO";
            }
            else
            {
                lblSituacao.ForeColor = Color.Red;
                lblSituacao.Text = "REPROVADO";
            }

            // Saida
            lblResultado.Text = "A média das notas é : " + Media.ToString();
        }
    }
}
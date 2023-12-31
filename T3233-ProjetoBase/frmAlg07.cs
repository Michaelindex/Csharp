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
    public partial class frmAlg07 : Form
    {
        public frmAlg07()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numeroFinal = int.Parse(txtNumeroFinal.Text);
            int somatoria = 0;
            lstSoma.Items.Clear();
            for (int i = 1; i <= numeroFinal; i++)
            {
                somatoria = somatoria + i;
                lstSoma.Items.Add($"Somando... {somatoria}");
            }
        }

        private void btnSomar2_Click(object sender, EventArgs e)
        {
            float numeroFinal = float.Parse(txtNumeroFinal.Text);
            float somatoria = (1 + numeroFinal) * (numeroFinal / 2);
            lstSoma.Items.Clear();
            lstSoma.Items.Add($"Somatória por GAUSS = {somatoria}");
        }
    }
}

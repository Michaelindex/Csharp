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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void algorítmo01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg01 frm = new frmAlg01();
            frm.ShowDialog();
            //frm.Show();
        }

        private void algorítmo02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg02 frm = new frmAlg02();
            frm.ShowDialog();
        }

        private void algorítmo03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg03 frm = new frmAlg03();
            frm.ShowDialog();
        }

        private void algorítmo04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg04 frm = new frmAlg04();
            frm.ShowDialog();
        }

        private void algorítmo05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg05 frm = new frmAlg05();
            frm.ShowDialog();
        }

        private void algorítmo06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg06 frm = new frmAlg06();
            frm.ShowDialog();
        }

        private void algorítmo07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg07 frm = new frmAlg07();
            frm.ShowDialog();
        }

        private void ntwExemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBco1 frm = new frmBco1();
            frm.ShowDialog();
        }

        private void ntwExemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBco2 frm = new frmBco2();
            frm.ShowDialog();
        }

        private void mercadinhoExemplo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBco3 frm = new frmBco3();
            frm.ShowDialog();
        }
    }
}

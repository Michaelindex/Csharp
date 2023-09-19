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
            Form2 frm = new Form2();
            frm.ShowDialog();
            //frm.Show();
        }

        private void algorítmo03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form03 frm = new Form03();
            frm.ShowDialog();
            //frm.Show();
        }
    }
}

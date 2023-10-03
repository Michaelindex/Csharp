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
    public partial class frmAlg05 : Form
    {
        public frmAlg05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lboResultado.Items.Clear();
            if (!string.IsNullOrEmpty(txtTabuada.Text) && int.TryParse(txtTabuada.Text, out int multiplicador))
            {
                for (int i = 1; i <= 10; i++)
                {
                    lboResultado.Items.Add($"{multiplicador} x {i} = {i * multiplicador}");
                }
            }
            else
            {
                MessageBox.Show("Dados inexistentes ou inválidos","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }


    }
}





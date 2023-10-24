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
    public partial class frmExtra1 : Form
    {
        public frmExtra1()
        {
            InitializeComponent();
        }
    }

    public class JogoAdivinhacao
    {
        private int numeroSecreto;
        private Random random;

        public JogoAdivinhacao()
        {
            random = new Random();
            GerarNumeroSecreto();
        }

        public void GerarNumeroSecreto()
        {
            numeroSecreto = random.Next(1, 101);
        }

        public string VerificarPalpite(int palpite)
        {
            if (palpite < numeroSecreto)
            {
                return "Muito baixo! Tente novamente.";
            }
            else if (palpite > numeroSecreto)
            {
                return "Muito alto! Tente novamente.";
            }
            else
            {
                return "Correto!";
            }
        }

    }
}

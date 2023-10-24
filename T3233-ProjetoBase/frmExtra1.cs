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
        private JogoAdivinhacao jogo;

        public frmExtra1()
        {
            InitializeComponent();
            jogo = new JogoAdivinhacao();
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            int palpite;
            if (int.TryParse(txtPalpite.Text, out palpite))
            {
                string resultado = jogo.VerificarPalpite(palpite);
                MessageBox.Show(resultado);

                if (resultado == "Correto!")
                {
                    DialogResult opcao = MessageBox.Show("Você acertou! Deseja jogar novamente?",
                        "Jogo de Adivinhação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcao == DialogResult.Yes)
                    {
                        jogo.GerarNumeroSecreto();
                        txtPalpite.Clear();
                    }
                    else
                    {
                        Close();
                    }
                }
                txtPalpite.Clear();
                txtPalpite.Focus();
            }
            else
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class JogoAdivinhacao
    {
        private int tentativas;
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
            tentativas += 1;
            if (palpite < numeroSecreto)
            {
                return $"Você tentou {tentativas} vezes.  Muito baixo! Tente novamente.";
            }
            else if (palpite > numeroSecreto)
            {
                return $"Você tentou {tentativas} vezes. Muito alto! Tente novamente.";
            }
            else
            {
                return $"Correto!";
            }
        }

    }
}

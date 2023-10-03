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
    public partial class frmAlg06 : Form
    {
        public frmAlg06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = txtNumero.Text;

            // Converte o valor para um número inteiro
            int numero;
            bool successo = int.TryParse(entrada, out numero);
            if (successo)
            {
                lboNumeros.Items.Add(entrada.ToString());
            }
            else
            {
                // Exibe uma mensagem de erro caso o valor digitado não seja um número
                MessageBox.Show("digite um número válido.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNumero.Text = string.Empty;
            txtNumero.Focus();
        }

        private void lboNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Passo 1: Criar uma lista para armazenar os números
            List<int> numeros = new List<int>();

            // Passo 2: Percorrer os itens da ListBox e adicionar números válidos à lista
            foreach (var item in lboNumeros.Items)
            {
                if (int.TryParse(item.ToString(), out int numero))
                {
                    numeros.Add(numero);
                }
            }

            // Passo 3: Ordenar a lista
            numeros.Sort();

            // Passo 4: Limpar a ListBox
            lboNumeros.Items.Clear();
            
            // Passo 5: Adicionar os números ordenados de volta à ListBox
            foreach (var numero in numeros)
            {
                lboNumeros.Items.Add(numero);
            }
        }
    }
}

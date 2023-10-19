using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace T3233_ProjetoBase
{
    public partial class frmBco4 : Form
    {
        private string conexao =
ConfigurationManager.ConnectionStrings[2].ConnectionString;

        // Variável de controle para definir INSERT ou UPDATE
        bool novo;

        public frmBco4()
        {
            InitializeComponent();
        }

        #region Métodos Criados

        #endregion
        private void resetaTela()
        {
            btnAdicionar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

            lblCodigo.Text = string.Empty;

            foreach(Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                    textBox.Enabled = false;
                }
            }
        }

        private void carregaGrid()
        {
            string sql = "SELECT codcli, nome ,cpf, rg, rua, telefone, cidade, cep, bairro,estado " +
                "FROM Clientes WHERE (nome + cpf + rg + rua + telefone + cidade + cep + bairro + estado " +
                "LIKE '%' + @PESQUISA + '%'";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@PESQUISA", txtPesquisa.Text);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvDados.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
                
            }
        }

        #region Botões

        #endregion

        #region Form, Caixas de Texto e GridView

        #endregion
    }
}

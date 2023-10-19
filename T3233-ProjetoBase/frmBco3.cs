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
    public partial class frmBco3 : Form
    {
        private string conexao =
ConfigurationManager.ConnectionStrings[2].ConnectionString;
        public frmBco3()
        {
            InitializeComponent();
        }

        private void cboTabelas_Click(object sender, EventArgs e)
        {
            btnSelecionarItem.Enabled = true;
        }

        private void btnSelecionarItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Você selecionou a tabela : {cboTabelas.SelectedItem}");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            string sql = $"SELECT * FROM {cboTabelas.SelectedValue}";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvGenerica.DataSource = table;
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

        private void frmBco3_Load(object sender, EventArgs e)
        {
            carregarCombo();
        }

        private void carregarCombo()
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT TABLE_NAME FROM information_schema.tables WHERE TABLE_NAME <> 'sysdiagrams'";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            cboTabelas.DisplayMember = "TABLE_NAME";
            cboTabelas.ValueMember = "TABLE_NAME";
            cboTabelas.DataSource = tb;
        }
    }
}

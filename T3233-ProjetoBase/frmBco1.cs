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
    public partial class frmBco1 : Form
    {
        private string conexao =
ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public frmBco1()
        {
            InitializeComponent();
        }

        private void carregarGrid()
        {
            string sql = "SELECT * FROM Categories";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvCategories.DataSource = table;
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

        private void carregarCombo()
        {
            SqlConnection con = new SqlConnection(conexao);

            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT CompanyName As Fornecedor FROM Suppliers ORDER BY Fornecedor";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            cboSuppliers.ValueMember = "Fornecedor";
            cboSuppliers.DataSource = tb;

            btnSelecionarItem.Enabled = true;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void btnCarregarCbo_Click(object sender, EventArgs e)
        {
            carregarCombo();
        }

        private void btnSelecionarItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Você selecionou o fornecedor : " + cboSuppliers.SelectedValue.ToString());

            MessageBox.Show($"Você selecionou o fornecedor : {cboSuppliers.SelectedValue}");
        }
    }
}

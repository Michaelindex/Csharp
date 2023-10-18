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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace T3233_ProjetoBase
{
    public partial class frmBco2 : Form
    {
        private string conexao =
ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public frmBco2()
        {
            InitializeComponent();
        }

        private void carregaCombo()
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            cboCategories.DisplayMember = "CategoryName";
            cboCategories.ValueMember = "CategoryID";
            cboCategories.DataSource = tb;
        }

        private void carregaGrid()
        {
            string sql = "SELECT Products.ProductID AS Código, Products.ProductName AS Produto, " +
                "Products.UnitPrice AS Preço, Products.UnitsInStock AS Estoque, " +
                "Categories.CategoryName AS Categoria " +
                "FROM Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID " +
                "WHERE Categories.CategoryID = " + cboCategories.SelectedValue;

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvProducts.DataSource = table;
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

        private void frmBco2_Load(object sender, EventArgs e)
        {
            carregaCombo();
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

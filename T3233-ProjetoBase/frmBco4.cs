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

        #region Botões

        #endregion

        #region Form, Caixas de Texto e GridView

        #endregion
    }
}

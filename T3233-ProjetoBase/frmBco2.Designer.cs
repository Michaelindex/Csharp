namespace T3233_ProjetoBase
{
    partial class frmBco2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboCategories = new ComboBox();
            btnCarregarDados = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // cboCategories
            // 
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(12, 18);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(165, 23);
            cboCategories.TabIndex = 8;
            // 
            // btnCarregarDados
            // 
            btnCarregarDados.Location = new Point(183, 17);
            btnCarregarDados.Name = "btnCarregarDados";
            btnCarregarDados.Size = new Size(228, 23);
            btnCarregarDados.TabIndex = 7;
            btnCarregarDados.Text = "Carregar Produtos Dessa Categoria";
            btnCarregarDados.UseVisualStyleBackColor = true;
            btnCarregarDados.Click += btnCarregarDados_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 46);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(766, 291);
            dgvProducts.TabIndex = 6;
            // 
            // frmBco2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 374);
            Controls.Add(cboCategories);
            Controls.Add(btnCarregarDados);
            Controls.Add(dgvProducts);
            Name = "frmBco2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind - Exemplo 2";
            Load += frmBco2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboCategories;
        private Button btnCarregarDados;
        private DataGridView dgvProducts;
    }
}
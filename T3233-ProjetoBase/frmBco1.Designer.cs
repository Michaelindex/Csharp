namespace T3233_ProjetoBase
{
    partial class frmBco1
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
            btnCarregar = new Button();
            dgvCategories = new DataGridView();
            cboSuppliers = new ComboBox();
            btnCarregarCbo = new Button();
            btnSelecionarItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(12, 338);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(197, 41);
            btnCarregar.TabIndex = 3;
            btnCarregar.Text = "Carregar GRID";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(12, 12);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(776, 304);
            dgvCategories.TabIndex = 2;
            // 
            // cboSuppliers
            // 
            cboSuppliers.FormattingEnabled = true;
            cboSuppliers.Location = new Point(587, 338);
            cboSuppliers.Name = "cboSuppliers";
            cboSuppliers.Size = new Size(204, 23);
            cboSuppliers.TabIndex = 5;
            // 
            // btnCarregarCbo
            // 
            btnCarregarCbo.Location = new Point(384, 338);
            btnCarregarCbo.Name = "btnCarregarCbo";
            btnCarregarCbo.Size = new Size(197, 41);
            btnCarregarCbo.TabIndex = 4;
            btnCarregarCbo.Text = "Carregar Combobox";
            btnCarregarCbo.UseVisualStyleBackColor = true;
            btnCarregarCbo.Click += btnCarregarCbo_Click;
            // 
            // btnSelecionarItem
            // 
            btnSelecionarItem.Enabled = false;
            btnSelecionarItem.Location = new Point(384, 385);
            btnSelecionarItem.Name = "btnSelecionarItem";
            btnSelecionarItem.Size = new Size(197, 41);
            btnSelecionarItem.TabIndex = 6;
            btnSelecionarItem.Text = "Selecionar Item da Combobox";
            btnSelecionarItem.UseVisualStyleBackColor = true;
            btnSelecionarItem.Click += btnSelecionarItem_Click;
            // 
            // frmBco1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnSelecionarItem);
            Controls.Add(cboSuppliers);
            Controls.Add(btnCarregarCbo);
            Controls.Add(btnCarregar);
            Controls.Add(dgvCategories);
            Name = "frmBco1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind - Exemplo 01";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarregar;
        private DataGridView dgvCategories;
        private ComboBox cboSuppliers;
        private Button btnCarregarCbo;
        private Button btnSelecionarItem;
    }
}
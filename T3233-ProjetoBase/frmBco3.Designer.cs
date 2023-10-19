namespace T3233_ProjetoBase
{
    partial class frmBco3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBco3));
            cboTabelas = new ComboBox();
            btnSelecionarItem = new Button();
            dgvGenerica = new DataGridView();
            btnCarregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGenerica).BeginInit();
            SuspendLayout();
            // 
            // cboTabelas
            // 
            cboTabelas.FormattingEnabled = true;
            cboTabelas.Location = new Point(45, 22);
            cboTabelas.Name = "cboTabelas";
            cboTabelas.Size = new Size(241, 23);
            cboTabelas.TabIndex = 0;
            cboTabelas.Click += cboTabelas_Click;
            // 
            // btnSelecionarItem
            // 
            btnSelecionarItem.Enabled = false;
            btnSelecionarItem.Location = new Point(541, 14);
            btnSelecionarItem.Name = "btnSelecionarItem";
            btnSelecionarItem.Size = new Size(197, 36);
            btnSelecionarItem.TabIndex = 7;
            btnSelecionarItem.Text = "Selecionar Item da Combobox";
            btnSelecionarItem.UseVisualStyleBackColor = true;
            btnSelecionarItem.Click += btnSelecionarItem_Click;
            // 
            // dgvGenerica
            // 
            dgvGenerica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenerica.Location = new Point(45, 67);
            dgvGenerica.Name = "dgvGenerica";
            dgvGenerica.RowTemplate.Height = 25;
            dgvGenerica.Size = new Size(693, 351);
            dgvGenerica.TabIndex = 8;
            // 
            // btnCarregar
            // 
            btnCarregar.BackgroundImage = (Image)resources.GetObject("btnCarregar.BackgroundImage");
            btnCarregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCarregar.Location = new Point(292, 4);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(65, 57);
            btnCarregar.TabIndex = 9;
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // frmBco3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarregar);
            Controls.Add(dgvGenerica);
            Controls.Add(btnSelecionarItem);
            Controls.Add(cboTabelas);
            Name = "frmBco3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mercadinho - Exemplo3";
            Load += frmBco3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGenerica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboTabelas;
        private Button btnSelecionarItem;
        private DataGridView dgvGenerica;
        private Button btnCarregar;
    }
}
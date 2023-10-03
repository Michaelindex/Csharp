namespace T3233_ProjetoBase
{
    partial class frmAlg06
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
            label1 = new Label();
            txtNumero = new TextBox();
            btnAdd = new Button();
            lboNumeros = new ListBox();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 5);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe Números : ";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 36);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(140, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // lboNumeros
            // 
            lboNumeros.FormattingEnabled = true;
            lboNumeros.ItemHeight = 15;
            lboNumeros.Location = new Point(12, 72);
            lboNumeros.Name = "lboNumeros";
            lboNumeros.Size = new Size(120, 289);
            lboNumeros.TabIndex = 3;
            lboNumeros.SelectedIndexChanged += lboNumeros_SelectedIndexChanged;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(172, 178);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(138, 76);
            btnOrdenar.TabIndex = 4;
            btnOrdenar.Text = "Ordenar Números";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // frmAlg06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 443);
            Controls.Add(btnOrdenar);
            Controls.Add(lboNumeros);
            Controls.Add(btnAdd);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "frmAlg06";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ALtoritmo 06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnAdd;
        private ListBox lboNumeros;
        private Button btnOrdenar;
    }
}
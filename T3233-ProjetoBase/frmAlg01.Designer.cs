namespace T3233_ProjetoBase
{
    partial class frmAlg01
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblResultado = new Label();
            lblSituacao = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtN3 = new TextBox();
            txtN4 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 0;
            label1.Text = "Informe a Nota 01";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(37, 80);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 0;
            label2.Text = "Informe a Nota 02:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(37, 116);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 0;
            label3.Text = "Informe a Nota 03:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(37, 152);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 0;
            label4.Text = "Informe a Nota 04:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Green;
            lblResultado.Location = new Point(37, 253);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 21);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado da Média:";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSituacao.ForeColor = Color.Green;
            lblSituacao.Location = new Point(37, 283);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(157, 21);
            lblSituacao.TabIndex = 0;
            lblSituacao.Text = "Situação do Aluno(a):";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(217, 44);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(67, 23);
            txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(217, 80);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(67, 23);
            txtN2.TabIndex = 1;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(217, 116);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(67, 23);
            txtN3.TabIndex = 2;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(217, 152);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(67, 23);
            txtN4.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(37, 197);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(148, 36);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular a Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmAlg01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 325);
            Controls.Add(btnCalcular);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(lblSituacao);
            Controls.Add(lblResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlg01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblResultado;
        private Label lblSituacao;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private TextBox txtN4;
        private Button btnCalcular;
    }
}
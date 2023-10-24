namespace T3233_ProjetoBase
{
    partial class frmExtra1
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
            btnResposta = new Button();
            label1 = new Label();
            txtPalpite = new TextBox();
            SuspendLayout();
            // 
            // btnResposta
            // 
            btnResposta.Location = new Point(43, 84);
            btnResposta.Name = "btnResposta";
            btnResposta.Size = new Size(210, 52);
            btnResposta.TabIndex = 5;
            btnResposta.Text = "Confirmar Palpite";
            btnResposta.UseVisualStyleBackColor = true;
            btnResposta.Click += btnResposta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 17);
            label1.Name = "label1";
            label1.Size = new Size(336, 21);
            label1.TabIndex = 4;
            label1.Text = "Tente adivinhar o número secreto ( de 1 a 100 )";
            // 
            // txtPalpite
            // 
            txtPalpite.Location = new Point(43, 41);
            txtPalpite.Name = "txtPalpite";
            txtPalpite.Size = new Size(100, 23);
            txtPalpite.TabIndex = 3;
            // 
            // frmExtra1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 195);
            Controls.Add(btnResposta);
            Controls.Add(label1);
            Controls.Add(txtPalpite);
            Name = "frmExtra1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Extra 1 - Jogo da Adivinhação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResposta;
        private Label label1;
        private TextBox txtPalpite;
    }
}
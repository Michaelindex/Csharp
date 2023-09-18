namespace T3233_ProjetoBase
{
    partial class Form2
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
            txtKm = new TextBox();
            txtHr = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "KMs Percorridos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 103);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 1;
            label2.Text = "Tempo Gasto ( em horas )";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(185, 25);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(100, 23);
            txtKm.TabIndex = 2;
            // 
            // txtHr
            // 
            txtHr.Location = new Point(185, 100);
            txtHr.Name = "txtHr";
            txtHr.Size = new Size(100, 23);
            txtHr.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(21, 170);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(264, 57);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular Velocidade Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 275);
            Controls.Add(btnCalcular);
            Controls.Add(txtHr);
            Controls.Add(txtKm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algoritmo 02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKm;
        private TextBox txtHr;
        private Button btnCalcular;
    }
}
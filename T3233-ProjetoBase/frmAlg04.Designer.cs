namespace T3233_ProjetoBase
{
    partial class frmAlg04
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
            txtIMC = new TextBox();
            btnCalcular = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblResultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(121, 224);
            txtIMC.Name = "txtIMC";
            txtIMC.ReadOnly = true;
            txtIMC.Size = new Size(100, 23);
            txtIMC.TabIndex = 21;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(29, 167);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(192, 40);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(121, 121);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 19;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(121, 71);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 226);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 15;
            label4.Text = "IMC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 121);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 16;
            label3.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 17;
            label2.Text = "Peso";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(51, 268);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(138, 25);
            lblResultado.TabIndex = 22;
            lblResultado.Text = "--------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 18;
            label1.Text = "Calcule o seu IMC";
            // 
            // frmAlg04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 336);
            Controls.Add(txtIMC);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "frmAlg04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIMC;
        private Button btnCalcular;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblResultado;
        private Label label1;
    }
}
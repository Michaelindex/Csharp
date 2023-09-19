namespace T3233_ProjetoBase
{
    partial class Form03
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
            btnCalcular = new Button();
            label5 = new Label();
            txtIMC = new TextBox();
            lblResultado = new Label();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 21);
            label1.Name = "label1";
            label1.Size = new Size(296, 47);
            label1.TabIndex = 0;
            label1.Text = "Calcule o seu IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 88);
            label2.Name = "label2";
            label2.Size = new Size(56, 30);
            label2.TabIndex = 1;
            label2.Text = "Peso";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 156);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 3;
            label3.Text = "Altura";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(35, 214);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(351, 49);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 286);
            label5.Name = "label5";
            label5.Size = new Size(51, 30);
            label5.TabIndex = 7;
            label5.Text = "IMC";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtIMC
            // 
            txtIMC.BackColor = Color.WhiteSmoke;
            txtIMC.Location = new Point(174, 295);
            txtIMC.Name = "txtIMC";
            txtIMC.ReadOnly = true;
            txtIMC.Size = new Size(212, 23);
            txtIMC.TabIndex = 8;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(136, 344);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(148, 28);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "-----------------";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(174, 165);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(212, 23);
            txtAltura.TabIndex = 4;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(174, 97);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(212, 23);
            txtPeso.TabIndex = 2;
            txtPeso.TextChanged += textBox1_TextChanged;
            // 
            // Form03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 411);
            Controls.Add(lblResultado);
            Controls.Add(txtIMC);
            Controls.Add(label5);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(label3);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03";
            Text = "Algoritmo04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label label5;
        private TextBox txtIMC;
        private Label lblResultado;
        private TextBox txtAltura;
        private TextBox txtPeso;
    }
}
﻿namespace T3233_ProjetoBase
{
    partial class frmAlg07
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
            btnSomar2 = new Button();
            lstSoma = new ListBox();
            btnSomar = new Button();
            txtNumeroFinal = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSomar2
            // 
            btnSomar2.Location = new Point(17, 115);
            btnSomar2.Name = "btnSomar2";
            btnSomar2.Size = new Size(175, 23);
            btnSomar2.TabIndex = 14;
            btnSomar2.Text = "Somar o intervalo (GAUSS)";
            btnSomar2.UseVisualStyleBackColor = true;
            btnSomar2.Click += btnSomar2_Click;
            // 
            // lstSoma
            // 
            lstSoma.ForeColor = Color.Navy;
            lstSoma.FormattingEnabled = true;
            lstSoma.ItemHeight = 15;
            lstSoma.Location = new Point(212, 28);
            lstSoma.Name = "lstSoma";
            lstSoma.Size = new Size(336, 274);
            lstSoma.TabIndex = 13;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(17, 76);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(175, 23);
            btnSomar.TabIndex = 12;
            btnSomar.Text = "Somar o intervalo (FOR)";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // txtNumeroFinal
            // 
            txtNumeroFinal.ForeColor = Color.FromArgb(0, 0, 192);
            txtNumeroFinal.Location = new Point(134, 28);
            txtNumeroFinal.Name = "txtNumeroFinal";
            txtNumeroFinal.Size = new Size(58, 23);
            txtNumeroFinal.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 10;
            label1.Text = "Somatória de 1 até :";
            // 
            // frmAlg07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 340);
            Controls.Add(btnSomar2);
            Controls.Add(lstSoma);
            Controls.Add(btnSomar);
            Controls.Add(txtNumeroFinal);
            Controls.Add(label1);
            Name = "frmAlg07";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomar2;
        private ListBox lstSoma;
        private Button btnSomar;
        private TextBox txtNumeroFinal;
        private Label label1;
    }
}
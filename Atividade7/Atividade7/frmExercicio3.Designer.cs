namespace Atividade7
{
    partial class frmExercicio3
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
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.btnCheca = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalindromo.Location = new System.Drawing.Point(12, 12);
            this.txtPalindromo.MaxLength = 50;
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(776, 45);
            this.txtPalindromo.TabIndex = 0;
            // 
            // btnCheca
            // 
            this.btnCheca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheca.Location = new System.Drawing.Point(354, 278);
            this.btnCheca.Name = "btnCheca";
            this.btnCheca.Size = new System.Drawing.Size(434, 118);
            this.btnCheca.TabIndex = 1;
            this.btnCheca.Text = "checar se eh palindromo";
            this.btnCheca.UseVisualStyleBackColor = true;
            this.btnCheca.Click += new System.EventHandler(this.btnCheca_Click);
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(12, 63);
            this.txtB.MaxLength = 50;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(776, 45);
            this.txtB.TabIndex = 0;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(12, 114);
            this.txtC.MaxLength = 50;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(776, 45);
            this.txtC.TabIndex = 0;
            // 
            // txtD
            // 
            this.txtD.Enabled = false;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(12, 165);
            this.txtD.MaxLength = 50;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(776, 45);
            this.txtD.TabIndex = 0;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.btnCheca);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtPalindromo);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalindromo;
        private System.Windows.Forms.Button btnCheca;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
    }
}
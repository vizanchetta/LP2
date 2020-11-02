namespace PMetodosMenus
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
            this.btnTrasPraFrente = new System.Windows.Forms.Button();
            this.btnInserePala1 = new System.Windows.Forms.Button();
            this.btnIndexOfSubstringLength = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrasPraFrente
            // 
            this.btnTrasPraFrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasPraFrente.Location = new System.Drawing.Point(467, 214);
            this.btnTrasPraFrente.Name = "btnTrasPraFrente";
            this.btnTrasPraFrente.Size = new System.Drawing.Size(127, 83);
            this.btnTrasPraFrente.TabIndex = 9;
            this.btnTrasPraFrente.Text = "retorna txt1 de trás pra frente";
            this.btnTrasPraFrente.UseVisualStyleBackColor = true;
            this.btnTrasPraFrente.Click += new System.EventHandler(this.btnTrasPraFrente_Click);
            // 
            // btnInserePala1
            // 
            this.btnInserePala1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserePala1.Location = new System.Drawing.Point(337, 214);
            this.btnInserePala1.Name = "btnInserePala1";
            this.btnInserePala1.Size = new System.Drawing.Size(127, 145);
            this.btnInserePala1.TabIndex = 10;
            this.btnInserePala1.Text = "Remove as Ocorrências do txt1 do txt2 usando Replace";
            this.btnInserePala1.UseVisualStyleBackColor = true;
            this.btnInserePala1.Click += new System.EventHandler(this.btnInserePala1_Click);
            // 
            // btnIndexOfSubstringLength
            // 
            this.btnIndexOfSubstringLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndexOfSubstringLength.Location = new System.Drawing.Point(207, 214);
            this.btnIndexOfSubstringLength.Name = "btnIndexOfSubstringLength";
            this.btnIndexOfSubstringLength.Size = new System.Drawing.Size(127, 224);
            this.btnIndexOfSubstringLength.TabIndex = 11;
            this.btnIndexOfSubstringLength.Text = "Remove as Ocorrências do txt1 do txt2 usando IndexOf, Substring e Length";
            this.btnIndexOfSubstringLength.UseVisualStyleBackColor = true;
            this.btnIndexOfSubstringLength.Click += new System.EventHandler(this.btnIndexOfSubstringLength_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra2.Location = new System.Drawing.Point(324, 135);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(252, 28);
            this.txtPalavra2.TabIndex = 8;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra1.Location = new System.Drawing.Point(324, 92);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(252, 28);
            this.txtPalavra1.TabIndex = 7;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(220, 140);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(86, 24);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(220, 92);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(86, 24);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrasPraFrente);
            this.Controls.Add(this.btnInserePala1);
            this.Controls.Add(this.btnIndexOfSubstringLength);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrasPraFrente;
        private System.Windows.Forms.Button btnInserePala1;
        private System.Windows.Forms.Button btnIndexOfSubstringLength;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
    }
}
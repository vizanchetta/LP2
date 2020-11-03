namespace Atividade7
{
    partial class frmExercicio1
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
            this.rtxTexto = new System.Windows.Forms.RichTextBox();
            this.btnUm = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxTexto
            // 
            this.rtxTexto.Location = new System.Drawing.Point(12, 12);
            this.rtxTexto.MaxLength = 50;
            this.rtxTexto.Name = "rtxTexto";
            this.rtxTexto.Size = new System.Drawing.Size(776, 215);
            this.rtxTexto.TabIndex = 0;
            this.rtxTexto.Text = "";
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(9, 245);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(247, 168);
            this.btnUm.TabIndex = 1;
            this.btnUm.Text = "Quantia de espaços em branco";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(277, 245);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(247, 168);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Quantia de ERRES ( R / r )";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(545, 245);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(247, 168);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "Quantia de letras duplas";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.rtxTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxTexto;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}
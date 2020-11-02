namespace PMetodosMenus
{
    partial class frmExercicio4
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
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContaNumeros = new System.Windows.Forms.Button();
            this.btnPrimeiroBranco = new System.Windows.Forms.Button();
            this.btnContaLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(5, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(786, 218);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Text = "";
            // 
            // btnContaNumeros
            // 
            this.btnContaNumeros.Location = new System.Drawing.Point(6, 236);
            this.btnContaNumeros.Name = "btnContaNumeros";
            this.btnContaNumeros.Size = new System.Drawing.Size(258, 202);
            this.btnContaNumeros.TabIndex = 1;
            this.btnContaNumeros.Text = "Conta Numeros";
            this.btnContaNumeros.UseVisualStyleBackColor = true;
            this.btnContaNumeros.Click += new System.EventHandler(this.btnContaNumeros_Click);
            // 
            // btnPrimeiroBranco
            // 
            this.btnPrimeiroBranco.Location = new System.Drawing.Point(270, 236);
            this.btnPrimeiroBranco.Name = "btnPrimeiroBranco";
            this.btnPrimeiroBranco.Size = new System.Drawing.Size(258, 202);
            this.btnPrimeiroBranco.TabIndex = 1;
            this.btnPrimeiroBranco.Text = "Posição Primeiro Espaço Branco";
            this.btnPrimeiroBranco.UseVisualStyleBackColor = true;
            this.btnPrimeiroBranco.Click += new System.EventHandler(this.btnPrimeiroBranco_Click);
            // 
            // btnContaLetras
            // 
            this.btnContaLetras.Location = new System.Drawing.Point(533, 236);
            this.btnContaLetras.Name = "btnContaLetras";
            this.btnContaLetras.Size = new System.Drawing.Size(258, 202);
            this.btnContaLetras.TabIndex = 1;
            this.btnContaLetras.Text = "Conte Letras";
            this.btnContaLetras.UseVisualStyleBackColor = true;
            this.btnContaLetras.Click += new System.EventHandler(this.btnContaLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContaLetras);
            this.Controls.Add(this.btnPrimeiroBranco);
            this.Controls.Add(this.btnContaNumeros);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Button btnContaNumeros;
        private System.Windows.Forms.Button btnPrimeiroBranco;
        private System.Windows.Forms.Button btnContaLetras;
    }
}
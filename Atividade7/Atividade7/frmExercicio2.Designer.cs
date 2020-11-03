namespace Atividade7
{
    partial class frmExercicio2
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
            this.btnGeraH = new System.Windows.Forms.Button();
            this.txtEntraN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeraH
            // 
            this.btnGeraH.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraH.Location = new System.Drawing.Point(85, 241);
            this.btnGeraH.Name = "btnGeraH";
            this.btnGeraH.Size = new System.Drawing.Size(595, 57);
            this.btnGeraH.TabIndex = 0;
            this.btnGeraH.Text = "calcula H";
            this.btnGeraH.UseVisualStyleBackColor = true;
            this.btnGeraH.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEntraN
            // 
            this.txtEntraN.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntraN.Location = new System.Drawing.Point(70, 64);
            this.txtEntraN.Name = "txtEntraN";
            this.txtEntraN.Size = new System.Drawing.Size(620, 49);
            this.txtEntraN.TabIndex = 1;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEntraN);
            this.Controls.Add(this.btnGeraH);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeraH;
        private System.Windows.Forms.TextBox txtEntraN;
    }
}
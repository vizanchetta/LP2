namespace CalculoSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskbxBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbtnFem = new System.Windows.Forms.RadioButton();
            this.rdbtnMasc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.lblTextoResultado = new System.Windows.Forms.Label();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(139, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 22);
            this.txtNome.TabIndex = 0;
            // 
            // mskbxBruto
            // 
            this.mskbxBruto.Location = new System.Drawing.Point(139, 47);
            this.mskbxBruto.Mask = "999000.09";
            this.mskbxBruto.Name = "mskbxBruto";
            this.mskbxBruto.Size = new System.Drawing.Size(148, 22);
            this.mskbxBruto.TabIndex = 1;
            // 
            // mskbxFilhos
            // 
            this.mskbxFilhos.Location = new System.Drawing.Point(139, 73);
            this.mskbxFilhos.Mask = "99";
            this.mskbxFilhos.Name = "mskbxFilhos";
            this.mskbxFilhos.Size = new System.Drawing.Size(148, 22);
            this.mskbxFilhos.TabIndex = 2;
            // 
            // mskbxAliqINSS
            // 
            this.mskbxAliqINSS.Enabled = false;
            this.mskbxAliqINSS.Location = new System.Drawing.Point(139, 261);
            this.mskbxAliqINSS.Name = "mskbxAliqINSS";
            this.mskbxAliqINSS.Size = new System.Drawing.Size(148, 22);
            this.mskbxAliqINSS.TabIndex = 5;
            // 
            // mskbxAliqIRPF
            // 
            this.mskbxAliqIRPF.Enabled = false;
            this.mskbxAliqIRPF.Location = new System.Drawing.Point(138, 289);
            this.mskbxAliqIRPF.Name = "mskbxAliqIRPF";
            this.mskbxAliqIRPF.Size = new System.Drawing.Size(148, 22);
            this.mskbxAliqIRPF.TabIndex = 6;
            // 
            // mskbxFamilia
            // 
            this.mskbxFamilia.Enabled = false;
            this.mskbxFamilia.Location = new System.Drawing.Point(138, 317);
            this.mskbxFamilia.Name = "mskbxFamilia";
            this.mskbxFamilia.Size = new System.Drawing.Size(148, 22);
            this.mskbxFamilia.TabIndex = 7;
            // 
            // mskbxLiquido
            // 
            this.mskbxLiquido.Enabled = false;
            this.mskbxLiquido.Location = new System.Drawing.Point(416, 373);
            this.mskbxLiquido.Name = "mskbxLiquido";
            this.mskbxLiquido.Size = new System.Drawing.Size(148, 22);
            this.mskbxLiquido.TabIndex = 10;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Location = new System.Drawing.Point(416, 258);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(148, 22);
            this.mskbxDescINSS.TabIndex = 8;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Location = new System.Drawing.Point(416, 286);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(148, 22);
            this.mskbxDescIRPF.TabIndex = 9;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(138, 118);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(148, 36);
            this.btnVerifica.TabIndex = 4;
            this.btnVerifica.Text = "Verifica Desconto";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbtnFem);
            this.grpSexo.Controls.Add(this.rdbtnMasc);
            this.grpSexo.Location = new System.Drawing.Point(309, 12);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(255, 93);
            this.grpSexo.TabIndex = 3;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbtnFem
            // 
            this.rdbtnFem.AutoSize = true;
            this.rdbtnFem.Location = new System.Drawing.Point(17, 55);
            this.rdbtnFem.Name = "rdbtnFem";
            this.rdbtnFem.Size = new System.Drawing.Size(86, 21);
            this.rdbtnFem.TabIndex = 1;
            this.rdbtnFem.Text = "Feminino";
            this.rdbtnFem.UseVisualStyleBackColor = true;
            // 
            // rdbtnMasc
            // 
            this.rdbtnMasc.AutoSize = true;
            this.rdbtnMasc.Checked = true;
            this.rdbtnMasc.Location = new System.Drawing.Point(17, 28);
            this.rdbtnMasc.Name = "rdbtnMasc";
            this.rdbtnMasc.Size = new System.Drawing.Size(92, 21);
            this.rdbtnMasc.TabIndex = 0;
            this.rdbtnMasc.TabStop = true;
            this.rdbtnMasc.Text = "Masculino";
            this.rdbtnMasc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desconto INSS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desconto IRPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alíquota INSS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alíquota IRPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salário Família";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salário Liquido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nome Funcionário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Salário Bruto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Número Filhos";
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(309, 118);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(82, 21);
            this.chkCasado.TabIndex = 3;
            this.chkCasado.Text = " Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // lblTextoResultado
            // 
            this.lblTextoResultado.AutoSize = true;
            this.lblTextoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoResultado.Location = new System.Drawing.Point(14, 168);
            this.lblTextoResultado.Name = "lblTextoResultado";
            this.lblTextoResultado.Size = new System.Drawing.Size(19, 29);
            this.lblTextoResultado.TabIndex = 6;
            this.lblTextoResultado.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 414);
            this.Controls.Add(this.lblTextoResultado);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxLiquido);
            this.Controls.Add(this.mskbxFamilia);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxAliqIRPF);
            this.Controls.Add(this.mskbxAliqINSS);
            this.Controls.Add(this.mskbxFilhos);
            this.Controls.Add(this.mskbxBruto);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Salário";
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskbxBruto;
        private System.Windows.Forms.MaskedTextBox mskbxFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxAliqINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbtnFem;
        private System.Windows.Forms.RadioButton rdbtnMasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.Label lblTextoResultado;
    }
}


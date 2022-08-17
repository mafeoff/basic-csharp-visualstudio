namespace Prova_2B2_12100161
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDiagnonais = new System.Windows.Forms.Button();
            this.btsPiramide = new System.Windows.Forms.Button();
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.CbxBase = new System.Windows.Forms.ComboBox();
            this.txtPercurso = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblResultadoDiagonal = new System.Windows.Forms.Label();
            this.lblResultadoPiramide = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cálculo da velocidade média ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume  da piramide";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Percurso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Aresta da Base";
            // 
            // btnDiagnonais
            // 
            this.btnDiagnonais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnonais.Location = new System.Drawing.Point(129, 345);
            this.btnDiagnonais.Name = "btnDiagnonais";
            this.btnDiagnonais.Size = new System.Drawing.Size(200, 73);
            this.btnDiagnonais.TabIndex = 7;
            this.btnDiagnonais.Text = "Calcular o Número de diagonais";
            this.btnDiagnonais.UseVisualStyleBackColor = true;
            this.btnDiagnonais.Click += new System.EventHandler(this.btnDiagnonais_Click);
            // 
            // btsPiramide
            // 
            this.btsPiramide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsPiramide.Location = new System.Drawing.Point(457, 345);
            this.btsPiramide.Name = "btsPiramide";
            this.btsPiramide.Size = new System.Drawing.Size(209, 73);
            this.btsPiramide.TabIndex = 8;
            this.btsPiramide.Text = "Calcular volume piramide";
            this.btsPiramide.UseVisualStyleBackColor = true;
            this.btsPiramide.Click += new System.EventHandler(this.btsPiramide_Click);
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaCampos.Location = new System.Drawing.Point(265, 496);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(200, 42);
            this.btnLimpaCampos.TabIndex = 9;
            this.btnLimpaCampos.Text = "Limpa Campos";
            this.btnLimpaCampos.UseVisualStyleBackColor = true;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // CbxBase
            // 
            this.CbxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxBase.FormattingEnabled = true;
            this.CbxBase.Items.AddRange(new object[] {
            "",
            "2",
            "4",
            "6",
            "10"});
            this.CbxBase.Location = new System.Drawing.Point(598, 207);
            this.CbxBase.Name = "CbxBase";
            this.CbxBase.Size = new System.Drawing.Size(121, 32);
            this.CbxBase.TabIndex = 10;
            // 
            // txtPercurso
            // 
            this.txtPercurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercurso.Location = new System.Drawing.Point(221, 204);
            this.txtPercurso.Name = "txtPercurso";
            this.txtPercurso.Size = new System.Drawing.Size(100, 29);
            this.txtPercurso.TabIndex = 11;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracao.Location = new System.Drawing.Point(221, 265);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(100, 29);
            this.txtDuracao.TabIndex = 12;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(510, 268);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(121, 29);
            this.txtAltura.TabIndex = 13;
            // 
            // lblResultadoDiagonal
            // 
            this.lblResultadoDiagonal.AutoSize = true;
            this.lblResultadoDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDiagonal.Location = new System.Drawing.Point(126, 440);
            this.lblResultadoDiagonal.Name = "lblResultadoDiagonal";
            this.lblResultadoDiagonal.Size = new System.Drawing.Size(11, 16);
            this.lblResultadoDiagonal.TabIndex = 14;
            this.lblResultadoDiagonal.Text = "/";
            // 
            // lblResultadoPiramide
            // 
            this.lblResultadoPiramide.AutoSize = true;
            this.lblResultadoPiramide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPiramide.Location = new System.Drawing.Point(454, 451);
            this.lblResultadoPiramide.Name = "lblResultadoPiramide";
            this.lblResultadoPiramide.Size = new System.Drawing.Size(11, 16);
            this.lblResultadoPiramide.TabIndex = 15;
            this.lblResultadoPiramide.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(279, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "em km/h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 573);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblResultadoPiramide);
            this.Controls.Add(this.lblResultadoDiagonal);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.txtPercurso);
            this.Controls.Add(this.CbxBase);
            this.Controls.Add(this.btnLimpaCampos);
            this.Controls.Add(this.btsPiramide);
            this.Controls.Add(this.btnDiagnonais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDiagnonais;
        private System.Windows.Forms.Button btsPiramide;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.ComboBox CbxBase;
        private System.Windows.Forms.TextBox txtPercurso;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblResultadoDiagonal;
        private System.Windows.Forms.Label lblResultadoPiramide;
        private System.Windows.Forms.Label label9;
    }
}


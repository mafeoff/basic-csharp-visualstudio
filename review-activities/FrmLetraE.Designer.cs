namespace Atividades_de_Revisão
{
    partial class FrmLetraE
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBalanca = new System.Windows.Forms.Button();
            this.txtBalanca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPLAY";
            // 
            // btnBalanca
            // 
            this.btnBalanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanca.Location = new System.Drawing.Point(595, 112);
            this.btnBalanca.Name = "btnBalanca";
            this.btnBalanca.Size = new System.Drawing.Size(101, 30);
            this.btnBalanca.TabIndex = 1;
            this.btnBalanca.Text = "Balança";
            this.btnBalanca.UseVisualStyleBackColor = true;
            this.btnBalanca.Click += new System.EventHandler(this.btnBalanca_Click);
            // 
            // txtBalanca
            // 
            this.txtBalanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanca.Location = new System.Drawing.Point(344, 112);
            this.txtBalanca.Name = "txtBalanca";
            this.txtBalanca.Size = new System.Drawing.Size(126, 26);
            this.txtBalanca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balança da refeição";
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagar.Location = new System.Drawing.Point(289, 181);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(0, 20);
            this.lblPagar.TabIndex = 4;
            // 
            // FrmLetraE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.lblPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBalanca);
            this.Controls.Add(this.btnBalanca);
            this.Controls.Add(this.label1);
            this.Name = "FrmLetraE";
            this.Text = "FrmLetraE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBalanca;
        private System.Windows.Forms.TextBox txtBalanca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPagar;
    }
}
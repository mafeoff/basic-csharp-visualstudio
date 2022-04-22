namespace Atividades_de_Revisão
{
    partial class FrmLetraA
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
            this.btsResposta = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btsResposta
            // 
            this.btsResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsResposta.Location = new System.Drawing.Point(114, 184);
            this.btsResposta.Name = "btsResposta";
            this.btsResposta.Size = new System.Drawing.Size(338, 48);
            this.btsResposta.TabIndex = 0;
            this.btsResposta.Text = "Convertor de Anos ";
            this.btsResposta.UseVisualStyleBackColor = true;
            this.btsResposta.Click += new System.EventHandler(this.btsResposta_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(107, 51);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(372, 37);
            this.lblPergunta.TabIndex = 1;
            this.lblPergunta.Text = "Quantos anos você tem?";
            // 
            // txtMeses
            // 
            this.txtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeses.Location = new System.Drawing.Point(182, 118);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(196, 44);
            this.txtMeses.TabIndex = 2;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(107, 285);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 37);
            this.lblResposta.TabIndex = 3;
            // 
            // FrmLetraA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(604, 416);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.btsResposta);
            this.Name = "FrmLetraA";
            this.Text = "FrmLetraA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsResposta;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label lblResposta;
    }
}
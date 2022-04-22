using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades_de_Revisão
{
    public partial class FrmLetraD : Form
    {
        public FrmLetraD()
        {
            InitializeComponent();
        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            float ValorProd = float.Parse(txtValorProduto.Text);
            float Dinheiro = float.Parse(txtDinheiro.Text);
            float Resultado = Dinheiro - ValorProd;
            lblTroco.Text = "Seu troco é de " + Resultado.ToString() + " Reais";

        }
    }
}

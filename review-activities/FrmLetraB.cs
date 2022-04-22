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
    public partial class FrmLetraB : Form
    {
        public FrmLetraB()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float Porcentagem = float.Parse(txtValorProduto.Text);
            float Resultado = (Porcentagem / 100) * 10;
            lblResultado.Text ="O valor de seu produto com este desconto é: " + Resultado.ToString() + "R$";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}

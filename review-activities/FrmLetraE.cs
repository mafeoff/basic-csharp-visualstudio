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
    public partial class FrmLetraE : Form
    {
        public FrmLetraE()
        {
            InitializeComponent();
        }

        private void btnBalanca_Click(object sender, EventArgs e)
        {
            float Valor = float.Parse(txtBalanca.Text);
            float Resultado = Valor * 34;
            lblPagar.Text = "Valor a pagar: "+ Resultado.ToString()+" Reais";
        }
    }
}

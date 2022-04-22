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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Resultado = Num1 + Num2;
            lblResultado.Text = Resultado.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Resultado = Num1 - Num2;
            lblResultado.Text = Resultado.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Resultado = Num1 * Num2;
            lblResultado.Text = Resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Resultado = Num1 / Num2;
            lblResultado.Text = Resultado.ToString();
        }
    }
}

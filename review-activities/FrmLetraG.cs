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

    public partial class FrmLetraG : Form
    {


        public FrmLetraG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Num3 = float.Parse(txtNum3.Text);
            float Resultado = Num1 + Num3;
            lblSoma.Text = Resultado.ToString();    

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Num3 = float.Parse(txtNum3.Text);
            float Resultado = (Num1 + Num2 + Num3)/3;
            lblMedia.Text = Resultado.ToString();

        }

        private void btsPorcent_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Num3 = float.Parse(txtNum3.Text);
            float Resultado1 = Num1 / 100;
            float Resultado2 =
            float Resultado3 =


        }
    }
}

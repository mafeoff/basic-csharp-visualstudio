using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaDeDecisão_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int Num1= int.Parse(txtNum1.Text);
            int Num2= int.Parse(txtNum2.Text);
            int Num3 = int.Parse(txtNum3.Text);

            if (Num1 > Num2 && Num1 > Num3)
            {
                lblResultado.Text = ("Salario 1 é maior");
            }
            else if(Num2 > Num1 && Num2 > Num3)
            {
                lblResultado.Text = ("Salario 2 é maior");
            }
            else
            {
                lblResultado.Text = ("Salario 3 é maior");
            }
        }
    }
}

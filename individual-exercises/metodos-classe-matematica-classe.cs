using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Matematica
    {
        public void Triplo(int numTri)
        {
            int tri = numTri * 3;
            MessageBox.Show("O triplo é:  " + tri);
        }
        public void Soma(float num1, float num2)
        {
            float soma = num1 + num2;
            MessageBox.Show("A soma é: " + soma);
        }
        public void Quadrado(float numQ)
        {
            float quad = numQ * numQ;
            MessageBox.Show("O quadrado  é " + quad);
        }
    }
}

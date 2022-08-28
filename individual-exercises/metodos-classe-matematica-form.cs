using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            int numTri = int.Parse(txt1.Text);
            //espressão da instancia da calasse
            Matematica mat = new Matematica();
            mat.Triplo(numTri);

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);

            Matematica mat = new Matematica();
            mat.Soma(num1, num2);

        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            float numQ = float.Parse(txtQuadrado.Text);

            Matematica mat = new Matematica();   
            mat.Quadrado(numQ);

        }
    }
}

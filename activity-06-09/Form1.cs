using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade06_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            While();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            DoWhile();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            For();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void While()
        {
            int contador = int.Parse(txtNum1.Text);
            int contador2 = int.Parse(txtNum2.Text);
            while (contador >= contador2)
            {
                lblResultado.Text += contador + " ";
                contador--;
            }
            if (contador < contador2)
            {
                MessageBox.Show(" O primeiro valor tem que ser o maior!");
            }
        }
        private void DoWhile()
        {
            int contador = int.Parse(txtNum1.Text);
            int contador2 = int.Parse(txtNum2.Text);
            do
            {
                lblResultado.Text += contador + " ";
                contador--;
            } while (contador >= contador2);
            if (contador < contador2)
            {
                MessageBox.Show(" O primeiro valor tem que ser o maior!");
            }
        }
        private void For()
        {
            int contador1 = int.Parse(txtNum1.Text);
            int contador2 = int.Parse(txtNum2.Text);

            for (int contador = contador1; contador >= contador2; contador--)
            {
                lblResultado.Text += contador + " ";
            }
            if (contador1 < contador2)
            {
                MessageBox.Show(" O primeiro valor tem que ser o maior!");
            }
        }
        private void LimpaCampos()
        {
            lblResultado.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}


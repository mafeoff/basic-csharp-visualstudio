using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtivLivro82
{
    public partial class Form2 : Form
    {
        int i = 0;
        int j = 0;
        int[,] matrix = new int[3, 3];
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Blank();
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                    label1.Text += matrix[i, j] + " ";
                }
                label1.Text += "\n";
            }
        }
        private void Blank()
        {
            btnExecutar.Visible = false;
            label1.Text = String.Empty;
        }
    }
}

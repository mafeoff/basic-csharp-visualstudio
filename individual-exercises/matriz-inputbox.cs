using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace matriz
{
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
        }

        private void btnComeco_Click(object sender, EventArgs e)
        {
            int[,] matrizesNumeros = new int[3, 3];
            for (int i = 0; i<3;i++)
            {
                for (int j = 0;  j < 3; j++)
                {
                    String valor = Interaction.InputBox("Insira nove elementos e obtenha uma matrix 3X3", "Matrizes");
                    matrizesNumeros[i, j] = int.Parse(valor);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lblResultado.Text += matrizesNumeros[i,j] + " ";
                }
                lblResultado.Text += "\n";
            }
        }
    }
}

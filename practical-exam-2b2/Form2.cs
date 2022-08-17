using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_2B2_12100161
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int contador = 0;
            contador++;

            while (contador < 16)

            {
                if (contador == 5)

                {
                    while (contador < 10)

                    {

                        lblResultado.Text += contador.ToString();
                        contador++;

                    }
        
                }

                else

                {
                    lblResultado.Text += contador.ToString();
                    contador++;
                    lblResultado.Text += "\n";
                }
                
            }

            


        }

 
    }
}

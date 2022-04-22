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
    public partial class FrmLetraF : Form
    {
        public FrmLetraF()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double Cubo = double.Parse(txtNum.Text);
            double Resultado = Math.Pow(Cubo, 3);
            lblResultado.Text = Resultado.ToString();
        }

        private void FrmLetraF_Load(object sender, EventArgs e)
        {

        }
    }
}

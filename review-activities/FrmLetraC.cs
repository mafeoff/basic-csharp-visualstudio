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
    public partial class FrmLetraC : Form
    {
        public FrmLetraC()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
             double Raiz = double.Parse(txtRaiz.Text);
            lblResult.Text = Math.Sqrt(Convert.ToDouble(Raiz)).ToString();
        }
    }
}

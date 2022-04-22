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
    public partial class FrmLetraA : Form
    {
        public FrmLetraA()
        {
            InitializeComponent();
        }

        private void btsResposta_Click(object sender, EventArgs e)
        {
            int meses = int.Parse(txtMeses.Text);
            int Resultado = meses * 12;
            lblResposta.Text = "Você viveu por " + Resultado.ToString() + " meses";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeDIA21
{
    public partial class lblDescricao : Form
    {
        public lblDescricao()
        {
            InitializeComponent();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            float precoCusto = float.Parse(txtCusto.Text);
            int estoque = int.Parse(txtEstoque.Text);
            float precoVendas = float.Parse(txtVenda.Text);
            float quantidade = float.Parse(txtQuantidade.Text);
            float imposto = float.Parse(txtImposto.Text);
            float soma;
            string verificacao = (cmbCategoria.Text);



            soma = precoVendas * imposto / 100;

            if (verificacao == "")
            {
                lblErroCategoria.Text = "Nao pode escolher um valor vazio";
            }

            if (precoCusto < 0)
            {
                lblErroPreço.Text = "Nao pode receber valor menor que 0";

            }
            if (estoque < 0)
            {
                lblErroDescricao.Text = "Nao pode receber valor menor que 0";
            }
            if (precoVendas < precoCusto)
            {
                lblErroVenda.Text = "Nao pode receber valor menor que" +
                    " o preço de custo";
            }
            if (quantidade < estoque)
            {
                lblErroQuantidade.Text = "Nao pode receber um valor menor que" +
                    " o do estoque";
            }
            if (precoCusto > 0 && estoque > 0 && precoCusto != 0 && estoque != 0 && precoVendas > precoCusto && quantidade >= estoque)
            {
                MessageBox.Show("Produto cadastro com sucesso!" +
                    "" +
                    "Valor do imposto:" +
                    "R$" + soma);

            }
        }
    }
}


    }
}
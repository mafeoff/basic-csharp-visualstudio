using System;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        bool operacaoFormada;
        string operador;
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operacaoFormada)
                txtDisplay.Clear();

            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
            operacaoFormada = false;
        }

        private void Operador(object sender, EventArgs e)
        {
            operacaoFormada = true;
            Button btn = (Button)sender;
            string novoOperador = btn.Text;

            txtHist.Text = txtHist.Text + " " + txtDisplay.Text + " " + novoOperador;

            Calcula();

            resultado = Double.Parse(txtDisplay.Text);
            operador = novoOperador;

        }

        private void Calcula()
        {
            switch (operador)
            {
                case "+": txtDisplay.Text = (resultado + Double.Parse(txtDisplay.Text)).ToString(); break;
                case "%": txtDisplay.Text = (resultado Double.Parse(txtDisplay.Text)).ToString(); break;
                case "-": txtDisplay.Text = (resultado - Double.Parse(txtDisplay.Text)).ToString(); break;
                case "x": txtDisplay.Text = (resultado * Double.Parse(txtDisplay.Text)).ToString(); break;
                case "÷":
                    if (txtDisplay.Text == "0")
                    {
                        txtDisplay.Text = "Divisão por zero";
                    }
                    else
                    {
                        txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString();
                    }

                    break;

                default: break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtHist.Text = "";
            resultado = 0;
            operador = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtHist.Text = "";
            operacaoFormada = true;

            Calcula();

            resultado = 0;
            if (Double.TryParse(txtDisplay.Text, out var valor))
            {
                resultado = valor;
            }

            txtDisplay.Text = resultado.ToString();
            resultado = 0;
            operador = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!operacaoFormada && !txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ",";
            }
            else if (operacaoFormada)
            {
                txtDisplay.Text = "0";
            }

            if (!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ",";
            }

            operacaoFormada = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {

        }
    }
}


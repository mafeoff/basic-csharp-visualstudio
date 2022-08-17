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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiagnonais_Click(object sender, EventArgs e)
        {

            int percurso = int.Parse(txtPercurso.Text);
            int duracao = int.Parse(txtDuracao.Text);
            lblResultadoDiagonal.Text = CalculaVelocidadeMedia(percurso, duracao);


        }

        private string CalculaVelocidadeMedia(int percurso, int duracao)
        {
            int VelocidadeMedia = percurso / duracao;
            return "O resultado da Velocidade Media é " + VelocidadeMedia + "km/h";


        }

        private void btsPiramide_Click(object sender, EventArgs e)
        {
            int aresta = int.Parse(txtAltura.Text);
            int altura = int.Parse(CbxBase.Text);
            lblResultadoPiramide.Text = CalculaArea(aresta, altura);

        }

        private string CalculaArea(int aresta, int altura)
        {
            int resultado = (aresta * altura) / 3;
            return " O volume da piramdide é de " + resultado + " cm3";
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtDuracao.Clear();
            txtPercurso.Clear();
            lblResultadoDiagonal.Text = "";
            lblResultadoPiramide.Text = "";
            CbxBase.SelectedIndex = -1;
        }
    }
}

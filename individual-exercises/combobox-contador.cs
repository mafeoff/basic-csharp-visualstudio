using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "0";
            comboBox2.Text = "0";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            CmbMethod();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            CmbMethod();
        }
        private void Clear()
        {
            textBox1.Text = "";



        }
        private void CmbMethod()
        {
            int cmb1 = int.Parse(comboBox1.Text);
            int cmb2 = int.Parse(comboBox2.Text);
            if (cmb1 >= cmb2)
            {
                while (cmb1 >= cmb2)
                {
                    textBox1.Text += cmb1 + " ";
                    cmb1--;
                }
            }
            else if (cmb2 >= cmb1)
            {
                while (cmb2 >= cmb1)
                {
                    textBox1.Text += cmb1 + " ";
                    cmb1++;
                }
            }
        }
    }
}
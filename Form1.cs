using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo ao meu aplicativo!");
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //int n1, n2, r;
            //n1 = Convert.ToInt32(txtNumero1.Text);  //Convertendo o conteudo do textbox para numero inteiro
            //n2 = Convert.ToInt32(txtNumero2.Text);
            //r = n1 + n2;
            //txtResultado.Text = Convert.ToString(r); //Convertendo o conteudo da variavel para texto no textbox
            RealizarOperacao((n1, n2) => n1 + n2);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            //int n1, n2, r;
            //n1 = Convert.ToInt32(txtNumero1.Text);  //Convertendo o conteudo do textbox para numero inteiro
            //n2 = Convert.ToInt32(txtNumero2.Text);
            //r = n1 - n2;
            //txtResultado.Text = Convert.ToString(r); //Convertendo o conteudo da variavel para texto no textbox
            RealizarOperacao((n1, n2) => n1 - n2);
        }
        private void RealizarOperacao(Func<double, double, double> operacao)  //criacao de um metodo separado para realizar a conversao
        {
            double n1 = Convert.ToDouble(txtNumero1.Text);  //Convertendo o conteudo do textbox para numero inteiro
            double n2 = Convert.ToDouble(txtNumero2.Text);
            double r = operacao(n1, n2);
            txtResultado.Text = r.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            RealizarOperacao((n1, n2) => n1 * n2);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            RealizarOperacao((n1, n2) => n1 / n2);
        }
    }
}

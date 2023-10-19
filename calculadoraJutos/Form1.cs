using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraJutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorTotal, valorJurosMensal, valorPrincipal, taxaJuros, valorParcela, valorJuros;
            int parcelas;

            taxaJuros = Convert.ToDouble(txtValorJuros.Text);
            valorPrincipal = Convert.ToDouble(txtValorPrincipal.Text);
            parcelas = Convert.ToInt32(txtParcelas.Text);

            valorJurosMensal = (taxaJuros / 100) / 12;
            valorParcela = valorPrincipal * (valorJurosMensal / (1 - Math.Pow(1 + valorJurosMensal, -parcelas)));
            valorTotal = valorParcela * parcelas;
            valorJuros = valorTotal - valorPrincipal;

            txtValorParcela.Text = valorParcela.ToString("F2");
            txtValorTotal.Text = valorTotal.ToString("F2");
            txtValorJuros.Text = valorJuros.ToString("F2");


        }
    }
}

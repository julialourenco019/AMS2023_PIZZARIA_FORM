using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPizzaria
{
    public partial class CadastrarPedido : Form
    {
        public CadastrarPedido()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPedido.Text = "";
            mskData.Text = "";
            cboProduto.Text = "";
            txtQuantidade.Text = "";
            txtSubtotal.Text = "";
            lblTotal.Text = "";
            txtValUnit.Text = "";
            txtPedido.Focus();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Variaveis.quant = Convert.ToInt32(txtQuantidade.Text);
            Variaveis.valUnit = Convert.ToDouble(txtValUnit.Text);
            Variaveis.valTotal = Variaveis.quant * Variaveis.valUnit;
            txtSubtotal.Text = Convert.ToString(Variaveis.valTotal);
            Variaveis.TotGeral = Variaveis.TotGeral + Variaveis.valTotal;
            lblTotal.Text = Convert.ToString(Variaveis.TotGeral);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ReceberPagamento FinalizarPedido = new ReceberPagamento();
            FinalizarPedido.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ReceberPagamento : Form
    {
        public ReceberPagamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(rbVista.Checked == true)
            {
                Variaveis.TotFinal = Variaveis.TotGeral * 0.95;
                txtTotal.Text = Convert.ToString(Variaveis.TotFinal);

            }

           else
            {
                if( rb2Vezes.Checked == true)
                {
                    Variaveis.TotFinal = Variaveis.TotGeral * 1.10;

                    lblParcela.Visible = true;
                    txtParcela.Visible = true;
                    txtParcela.Text = Convert.ToString(Variaveis.TotFinal / 2);
                    txtTotal.Text = Convert.ToString(Variaveis.TotFinal);

                }

            else
                {
                    if(rb3Vezes.Checked == true)
                    {
                        Variaveis.TotFinal = Variaveis.TotGeral * 1.15;
                       lblParcela.Visible = true;
                        txtParcela.Visible = true;
                        txtParcela.Text = Convert.ToString(Variaveis.TotFinal / 3);
                        txtTotal.Text = Convert.ToString(Variaveis.TotFinal);



                    }
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rbVista.Checked = false;
            rb2Vezes.Checked = false;
            rb3Vezes.Checked = false;
            txtParcela.Text = "";
            lblParcela.Visible = false;
            txtTotal.Text = "";
            txtParcela.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

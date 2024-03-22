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
    public partial class CadastrarCliente : Form
    {
       
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
            txtEndereco.Text = "";
            mskFone.Text = "";
            txtBairro.Text = "";
            mskCep.Text = "";
            mskData.Text = "";
            txtCodigoCliente.Focus();
        }

        private void btnFecharCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            if(txtCodigoCliente.Text !="" && txtNomeCliente.Text != "" && txtEndereco.Text!=" " && mskFone.Text !=""
                && txtBairro.Text !="" && mskCep.Text!= "" && mskData.Text != "")
            {
                MessageBox.Show("Cadastro feito com Sucesso","Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtFone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

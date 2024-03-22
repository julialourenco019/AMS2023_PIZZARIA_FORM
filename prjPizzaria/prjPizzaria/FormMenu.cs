using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPizzaria
{
    public partial class FormMenu : Form
    {
        Thread nt;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbMarguerita_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if ( rbReceberPagamento.Checked == true )
            {
               
                nt = new Thread(novoForm1);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else if ( rbCadastrarCliente.Checked == true)
            {
               
                nt = new Thread(novoForm3);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else if ( rbCadastrarPedido.Checked == true)
            {
                
                nt = new Thread(novoForm2);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Usúario ou Senha inválidos!");
            }

        }

        private void novoForm1()
        {
            Application.Run(new ReceberPagamento());
        }
        private void novoForm2()
        {
            Application.Run(new CadastrarPedido());
        }
        private void novoForm3()
        {
            Application.Run(new CadastrarCliente());
        }

        private void btnMenuLimpar_Click(object sender, EventArgs e)
        {
            rbCadastrarCliente.Checked = false;
            rbReceberPagamento.Checked = false;
            rbCadastrarPedido.Checked = false;
            gbMenu.Focus();


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void rbReceberPagamento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCadastrarPedido_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

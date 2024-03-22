using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace prjPizzaria
{
    public partial class prjPizzaria : Form
    {
        Thread nt;
        public prjPizzaria()
        {
            InitializeComponent();
        }
        
        private void prjPizzaria_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsario.Text == "julia" && txtSenha.Text == "12345" )
            {
                
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Usúario ou Senha inválidos!");
            }
        }

        private void novoForm()
        {
            Application.Run(new FormMenu());
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 14;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsario.Clear();
            txtSenha.Clear();
            txtUsario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" o projeto será encerrado", "atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)

            {

                Application.Exit();



            }
            else
            {
                MessageBox.Show(" o projeto continuará em execução",
                    "projeto pizza ", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void txtUsario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

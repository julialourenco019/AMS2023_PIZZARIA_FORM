
namespace prjPizzaria
{
    partial class ReceberPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceberPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.rb3Vezes = new System.Windows.Forms.RadioButton();
            this.rb2Vezes = new System.Windows.Forms.RadioButton();
            this.rbVista = new System.Windows.Forms.RadioButton();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receber Pagamento";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // gbPagamento
            // 
            this.gbPagamento.Controls.Add(this.rb3Vezes);
            this.gbPagamento.Controls.Add(this.rb2Vezes);
            this.gbPagamento.Controls.Add(this.rbVista);
            this.gbPagamento.Location = new System.Drawing.Point(286, 124);
            this.gbPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Padding = new System.Windows.Forms.Padding(5);
            this.gbPagamento.Size = new System.Drawing.Size(380, 162);
            this.gbPagamento.TabIndex = 1;
            this.gbPagamento.TabStop = false;
            this.gbPagamento.Text = "Selecione a Forma de Pagamento";
            this.gbPagamento.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb3Vezes
            // 
            this.rb3Vezes.AutoSize = true;
            this.rb3Vezes.Location = new System.Drawing.Point(32, 124);
            this.rb3Vezes.Margin = new System.Windows.Forms.Padding(5);
            this.rb3Vezes.Name = "rb3Vezes";
            this.rb3Vezes.Size = new System.Drawing.Size(220, 25);
            this.rb3Vezes.TabIndex = 2;
            this.rb3Vezes.TabStop = true;
            this.rb3Vezes.Text = "3 vezes ( acréscimo 15%)";
            this.rb3Vezes.UseVisualStyleBackColor = true;
            // 
            // rb2Vezes
            // 
            this.rb2Vezes.AutoSize = true;
            this.rb2Vezes.Location = new System.Drawing.Point(32, 86);
            this.rb2Vezes.Margin = new System.Windows.Forms.Padding(5);
            this.rb2Vezes.Name = "rb2Vezes";
            this.rb2Vezes.Size = new System.Drawing.Size(220, 25);
            this.rb2Vezes.TabIndex = 1;
            this.rb2Vezes.TabStop = true;
            this.rb2Vezes.Text = "2 vezes ( acréscimo 10%)";
            this.rb2Vezes.UseVisualStyleBackColor = true;
            // 
            // rbVista
            // 
            this.rbVista.AutoSize = true;
            this.rbVista.Location = new System.Drawing.Point(32, 47);
            this.rbVista.Margin = new System.Windows.Forms.Padding(5);
            this.rbVista.Name = "rbVista";
            this.rbVista.Size = new System.Drawing.Size(195, 25);
            this.rbVista.TabIndex = 0;
            this.rbVista.TabStop = true;
            this.rbVista.Text = "A vista (desconto 5%)";
            this.rbVista.UseVisualStyleBackColor = true;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblParcela.Location = new System.Drawing.Point(284, 329);
            this.lblParcela.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(130, 21);
            this.lblParcela.TabIndex = 2;
            this.lblParcela.Text = "Valor da parcela";
            this.lblParcela.Visible = false;
//            this.lblParcela.Click += new System.EventHandler(this.lblParcela_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(282, 389);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(174, 21);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Valor Total a ser pago";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(284, 461);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 37);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpar.Location = new System.Drawing.Point(419, 461);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 37);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.Location = new System.Drawing.Point(554, 461);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 37);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtParcela
            // 
            this.txtParcela.Enabled = false;
            this.txtParcela.Location = new System.Drawing.Point(433, 326);
            this.txtParcela.Margin = new System.Windows.Forms.Padding(5);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(233, 29);
            this.txtParcela.TabIndex = 7;
            this.txtParcela.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(466, 386);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 29);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ReceberPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.gbPagamento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReceberPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber Pagamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbPagamento.ResumeLayout(false);
            this.gbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPagamento;
        private System.Windows.Forms.RadioButton rb3Vezes;
        private System.Windows.Forms.RadioButton rb2Vezes;
        private System.Windows.Forms.RadioButton rbVista;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
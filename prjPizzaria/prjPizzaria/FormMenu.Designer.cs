namespace prjPizzaria
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.rbReceberPagamento = new System.Windows.Forms.RadioButton();
            this.rbCadastrarPedido = new System.Windows.Forms.RadioButton();
            this.rbCadastrarCliente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMenuLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzaria Borda e Lenha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.rbReceberPagamento);
            this.gbMenu.Controls.Add(this.rbCadastrarPedido);
            this.gbMenu.Controls.Add(this.rbCadastrarCliente);
            this.gbMenu.Location = new System.Drawing.Point(327, 158);
            this.gbMenu.Margin = new System.Windows.Forms.Padding(5);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Padding = new System.Windows.Forms.Padding(5);
            this.gbMenu.Size = new System.Drawing.Size(333, 162);
            this.gbMenu.TabIndex = 1;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu ";
            this.gbMenu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbReceberPagamento
            // 
            this.rbReceberPagamento.AutoSize = true;
            this.rbReceberPagamento.Location = new System.Drawing.Point(45, 104);
            this.rbReceberPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.rbReceberPagamento.Name = "rbReceberPagamento";
            this.rbReceberPagamento.Size = new System.Drawing.Size(176, 25);
            this.rbReceberPagamento.TabIndex = 2;
            this.rbReceberPagamento.TabStop = true;
            this.rbReceberPagamento.Text = "Receber pagamento";
            this.rbReceberPagamento.UseVisualStyleBackColor = true;
            this.rbReceberPagamento.CheckedChanged += new System.EventHandler(this.rbReceberPagamento_CheckedChanged);
            // 
            // rbCadastrarPedido
            // 
            this.rbCadastrarPedido.AutoSize = true;
            this.rbCadastrarPedido.Location = new System.Drawing.Point(45, 69);
            this.rbCadastrarPedido.Margin = new System.Windows.Forms.Padding(5);
            this.rbCadastrarPedido.Name = "rbCadastrarPedido";
            this.rbCadastrarPedido.Size = new System.Drawing.Size(158, 25);
            this.rbCadastrarPedido.TabIndex = 1;
            this.rbCadastrarPedido.TabStop = true;
            this.rbCadastrarPedido.Text = "Cadastrar Pedido";
            this.rbCadastrarPedido.UseVisualStyleBackColor = true;
            this.rbCadastrarPedido.CheckedChanged += new System.EventHandler(this.rbCadastrarPedido_CheckedChanged);
            // 
            // rbCadastrarCliente
            // 
            this.rbCadastrarCliente.AutoSize = true;
            this.rbCadastrarCliente.Location = new System.Drawing.Point(45, 32);
            this.rbCadastrarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.rbCadastrarCliente.Name = "rbCadastrarCliente";
            this.rbCadastrarCliente.Size = new System.Drawing.Size(156, 25);
            this.rbCadastrarCliente.TabIndex = 0;
            this.rbCadastrarCliente.TabStop = true;
            this.rbCadastrarCliente.Text = "Cadastrar Cliente";
            this.rbCadastrarCliente.UseVisualStyleBackColor = true;
            this.rbCadastrarCliente.CheckedChanged += new System.EventHandler(this.rbMarguerita_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenu.Location = new System.Drawing.Point(446, 353);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(102, 39);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Confirmar";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMenuLimpar
            // 
            this.btnMenuLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenuLimpar.Location = new System.Drawing.Point(568, 353);
            this.btnMenuLimpar.Name = "btnMenuLimpar";
            this.btnMenuLimpar.Size = new System.Drawing.Size(92, 39);
            this.btnMenuLimpar.TabIndex = 4;
            this.btnMenuLimpar.Text = "Limpar";
            this.btnMenuLimpar.UseVisualStyleBackColor = false;
            this.btnMenuLimpar.Click += new System.EventHandler(this.btnMenuLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(327, 353);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(103, 39);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMenuLimpar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.RadioButton rbReceberPagamento;
        private System.Windows.Forms.RadioButton rbCadastrarPedido;
        private System.Windows.Forms.RadioButton rbCadastrarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMenuLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}
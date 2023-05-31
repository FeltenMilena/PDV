
namespace PDV
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosProd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLancarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradaSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradaSaidaRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuRelatorios,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1339, 28);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncionarios,
            this.MenuClientes,
            this.MenuUsuarios,
            this.MenuCargos,
            this.MenuFornecedor});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(88, 24);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(175, 26);
            this.MenuFuncionarios.Text = "Funcionários";
            this.MenuFuncionarios.Click += new System.EventHandler(this.MenuFuncionarios_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(175, 26);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(175, 26);
            this.MenuUsuarios.Text = "Usuários";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(175, 26);
            this.MenuCargos.Text = "Cargos";
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(175, 26);
            this.MenuFornecedor.Text = "Fornecedor";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosProd,
            this.MenuEstoque});
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(82, 24);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuProdutosProd
            // 
            this.MenuProdutosProd.Name = "MenuProdutosProd";
            this.MenuProdutosProd.Size = new System.Drawing.Size(151, 26);
            this.MenuProdutosProd.Text = "Produtos";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(151, 26);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxoCaixa,
            this.MenuLancarVenda,
            this.MenuEntradaSaida,
            this.MenuDespesas});
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(128, 24);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // MenuFluxoCaixa
            // 
            this.MenuFluxoCaixa.Name = "MenuFluxoCaixa";
            this.MenuFluxoCaixa.Size = new System.Drawing.Size(206, 26);
            this.MenuFluxoCaixa.Text = "Fluxo Caixa";
            // 
            // MenuLancarVenda
            // 
            this.MenuLancarVenda.Name = "MenuLancarVenda";
            this.MenuLancarVenda.Size = new System.Drawing.Size(206, 26);
            this.MenuLancarVenda.Text = "Lançar Venda";
            // 
            // MenuEntradaSaida
            // 
            this.MenuEntradaSaida.Name = "MenuEntradaSaida";
            this.MenuEntradaSaida.Size = new System.Drawing.Size(206, 26);
            this.MenuEntradaSaida.Text = "Entradas / Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(206, 26);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosRel,
            this.MenuVendas,
            this.MenuMovimentos,
            this.MenuEntradaSaidaRel,
            this.MenuDespesasRel});
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(90, 24);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuProdutosRel
            // 
            this.MenuProdutosRel.Name = "MenuProdutosRel";
            this.MenuProdutosRel.Size = new System.Drawing.Size(202, 26);
            this.MenuProdutosRel.Text = "Produtos";
            // 
            // MenuVendas
            // 
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(202, 26);
            this.MenuVendas.Text = "Vendas";
            // 
            // MenuMovimentos
            // 
            this.MenuMovimentos.Name = "MenuMovimentos";
            this.MenuMovimentos.Size = new System.Drawing.Size(202, 26);
            this.MenuMovimentos.Text = "Movimentos";
            // 
            // MenuEntradaSaidaRel
            // 
            this.MenuEntradaSaidaRel.Name = "MenuEntradaSaidaRel";
            this.MenuEntradaSaidaRel.Size = new System.Drawing.Size(202, 26);
            this.MenuEntradaSaidaRel.Text = "Entradas/ Saídas";
            // 
            // MenuDespesasRel
            // 
            this.MenuDespesasRel.Name = "MenuDespesasRel";
            this.MenuDespesasRel.Size = new System.Drawing.Size(202, 26);
            this.MenuDespesasRel.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(48, 24);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img02
            // 
            this.img02.Image = global::PDV.Properties.Resources.imagemMovimentacoes;
            this.img02.Location = new System.Drawing.Point(764, 92);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(285, 198);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 4;
            this.img02.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::PDV.Properties.Resources.imagemLancamentoDespesas;
            this.img03.Location = new System.Drawing.Point(312, 403);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(285, 198);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img03.TabIndex = 3;
            this.img03.TabStop = false;
            // 
            // img04
            // 
            this.img04.Image = global::PDV.Properties.Resources.imagemLancarCaixa;
            this.img04.Location = new System.Drawing.Point(764, 438);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(285, 198);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 2;
            this.img04.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::PDV.Properties.Resources.imagemVenda;
            this.img01.Location = new System.Drawing.Point(312, 92);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(285, 237);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1339, 753);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosProd;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLancarVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradaSaida;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentos;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradaSaidaRel;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesasRel;
    }
}


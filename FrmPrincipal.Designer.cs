namespace Loja
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ItemMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMarcasCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMarcasListar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMarcasConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCarros = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCarrosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCarrosListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMarcas,
            this.ItemCarros});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ItemMarcas
            // 
            this.ItemMarcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMarcasCadastrar,
            this.ItemMarcasListar,
            this.ItemMarcasConsultar});
            this.ItemMarcas.Name = "ItemMarcas";
            this.ItemMarcas.Size = new System.Drawing.Size(57, 20);
            this.ItemMarcas.Text = "Marcas";
            // 
            // ItemMarcasCadastrar
            // 
            this.ItemMarcasCadastrar.Name = "ItemMarcasCadastrar";
            this.ItemMarcasCadastrar.Size = new System.Drawing.Size(125, 22);
            this.ItemMarcasCadastrar.Text = "Cadastrar";
            this.ItemMarcasCadastrar.Click += new System.EventHandler(this.ItemMarcasCadastrar_Click);
            // 
            // ItemMarcasListar
            // 
            this.ItemMarcasListar.Name = "ItemMarcasListar";
            this.ItemMarcasListar.Size = new System.Drawing.Size(125, 22);
            this.ItemMarcasListar.Text = "Listar";
            this.ItemMarcasListar.Click += new System.EventHandler(this.ItemMarcasListar_Click);
            // 
            // ItemMarcasConsultar
            // 
            this.ItemMarcasConsultar.Name = "ItemMarcasConsultar";
            this.ItemMarcasConsultar.Size = new System.Drawing.Size(125, 22);
            this.ItemMarcasConsultar.Text = "Consultar";
            this.ItemMarcasConsultar.Click += new System.EventHandler(this.ItemMarcasConsultar_Click);
            // 
            // ItemCarros
            // 
            this.ItemCarros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemCarrosCadastrar,
            this.ItemCarrosListar});
            this.ItemCarros.Name = "ItemCarros";
            this.ItemCarros.Size = new System.Drawing.Size(53, 20);
            this.ItemCarros.Text = "Carros";
            // 
            // ItemCarrosCadastrar
            // 
            this.ItemCarrosCadastrar.Name = "ItemCarrosCadastrar";
            this.ItemCarrosCadastrar.Size = new System.Drawing.Size(180, 22);
            this.ItemCarrosCadastrar.Text = "Cadastrar";
            this.ItemCarrosCadastrar.Click += new System.EventHandler(this.ItemCarrosCadastrar_Click);
            // 
            // ItemCarrosListar
            // 
            this.ItemCarrosListar.Name = "ItemCarrosListar";
            this.ItemCarrosListar.Size = new System.Drawing.Size(180, 22);
            this.ItemCarrosListar.Text = "Listar";
            this.ItemCarrosListar.Click += new System.EventHandler(this.ItemCarrosListar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Loja";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ItemMarcas;
        private System.Windows.Forms.ToolStripMenuItem ItemMarcasCadastrar;
        private System.Windows.Forms.ToolStripMenuItem ItemCarros;
        private System.Windows.Forms.ToolStripMenuItem ItemCarrosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem ItemCarrosListar;
        private System.Windows.Forms.ToolStripMenuItem ItemMarcasListar;
        private System.Windows.Forms.ToolStripMenuItem ItemMarcasConsultar;
    }
}


namespace Loja
{
    partial class FrmMarcasSalvar
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
            this.lblMarcasSalvarNome = new System.Windows.Forms.Label();
            this.txtMarcasSalvar = new System.Windows.Forms.TextBox();
            this.btnMarcasSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarcasSalvarNome
            // 
            this.lblMarcasSalvarNome.AutoSize = true;
            this.lblMarcasSalvarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcasSalvarNome.Location = new System.Drawing.Point(36, 38);
            this.lblMarcasSalvarNome.Name = "lblMarcasSalvarNome";
            this.lblMarcasSalvarNome.Size = new System.Drawing.Size(55, 20);
            this.lblMarcasSalvarNome.TabIndex = 0;
            this.lblMarcasSalvarNome.Text = "Nome";
            // 
            // txtMarcasSalvar
            // 
            this.txtMarcasSalvar.Location = new System.Drawing.Point(40, 71);
            this.txtMarcasSalvar.Name = "txtMarcasSalvar";
            this.txtMarcasSalvar.Size = new System.Drawing.Size(273, 20);
            this.txtMarcasSalvar.TabIndex = 1;
            // 
            // btnMarcasSalvar
            // 
            this.btnMarcasSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMarcasSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcasSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarcasSalvar.Location = new System.Drawing.Point(238, 111);
            this.btnMarcasSalvar.Name = "btnMarcasSalvar";
            this.btnMarcasSalvar.Size = new System.Drawing.Size(75, 34);
            this.btnMarcasSalvar.TabIndex = 2;
            this.btnMarcasSalvar.Text = "Salvar";
            this.btnMarcasSalvar.UseVisualStyleBackColor = false;
            this.btnMarcasSalvar.Click += new System.EventHandler(this.btnMarcasSalvar_Click);
            // 
            // FrmMarcasSalvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 218);
            this.Controls.Add(this.btnMarcasSalvar);
            this.Controls.Add(this.txtMarcasSalvar);
            this.Controls.Add(this.lblMarcasSalvarNome);
            this.Name = "FrmMarcasSalvar";
            this.Text = "Cadastrar Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcasSalvarNome;
        private System.Windows.Forms.TextBox txtMarcasSalvar;
        private System.Windows.Forms.Button btnMarcasSalvar;
    }
}
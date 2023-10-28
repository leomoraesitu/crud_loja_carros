namespace Loja
{
    partial class FrmCarrosSalvar
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
            this.btnCarrosSalvar = new System.Windows.Forms.Button();
            this.txtNomeCarrosSalvar = new System.Windows.Forms.TextBox();
            this.lblNomeCarrosSalvar = new System.Windows.Forms.Label();
            this.lblMarcasCarrosSalvar = new System.Windows.Forms.Label();
            this.cmbMarcaCarrosSalvar = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarrosSalvar
            // 
            this.btnCarrosSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCarrosSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrosSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarrosSalvar.Location = new System.Drawing.Point(233, 386);
            this.btnCarrosSalvar.Name = "btnCarrosSalvar";
            this.btnCarrosSalvar.Size = new System.Drawing.Size(75, 34);
            this.btnCarrosSalvar.TabIndex = 5;
            this.btnCarrosSalvar.Text = "Salvar";
            this.btnCarrosSalvar.UseVisualStyleBackColor = false;
            this.btnCarrosSalvar.Click += new System.EventHandler(this.btnCarrosSalvar_Click);
            // 
            // txtNomeCarrosSalvar
            // 
            this.txtNomeCarrosSalvar.Location = new System.Drawing.Point(35, 68);
            this.txtNomeCarrosSalvar.Name = "txtNomeCarrosSalvar";
            this.txtNomeCarrosSalvar.Size = new System.Drawing.Size(273, 20);
            this.txtNomeCarrosSalvar.TabIndex = 4;
            // 
            // lblNomeCarrosSalvar
            // 
            this.lblNomeCarrosSalvar.AutoSize = true;
            this.lblNomeCarrosSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCarrosSalvar.Location = new System.Drawing.Point(31, 35);
            this.lblNomeCarrosSalvar.Name = "lblNomeCarrosSalvar";
            this.lblNomeCarrosSalvar.Size = new System.Drawing.Size(67, 20);
            this.lblNomeCarrosSalvar.TabIndex = 3;
            this.lblNomeCarrosSalvar.Text = "Modelo";
            // 
            // lblMarcasCarrosSalvar
            // 
            this.lblMarcasCarrosSalvar.AutoSize = true;
            this.lblMarcasCarrosSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcasCarrosSalvar.Location = new System.Drawing.Point(31, 271);
            this.lblMarcasCarrosSalvar.Name = "lblMarcasCarrosSalvar";
            this.lblMarcasCarrosSalvar.Size = new System.Drawing.Size(58, 20);
            this.lblMarcasCarrosSalvar.TabIndex = 6;
            this.lblMarcasCarrosSalvar.Text = "Marca";
            // 
            // cmbMarcaCarrosSalvar
            // 
            this.cmbMarcaCarrosSalvar.FormattingEnabled = true;
            this.cmbMarcaCarrosSalvar.Location = new System.Drawing.Point(35, 307);
            this.cmbMarcaCarrosSalvar.Name = "cmbMarcaCarrosSalvar";
            this.cmbMarcaCarrosSalvar.Size = new System.Drawing.Size(273, 21);
            this.cmbMarcaCarrosSalvar.TabIndex = 7;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(35, 138);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(63, 20);
            this.txtAno.TabIndex = 9;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(31, 105);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 20);
            this.lblAno.TabIndex = 8;
            this.lblAno.Text = "Ano";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(35, 218);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(105, 20);
            this.txtCor.TabIndex = 11;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(31, 185);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(37, 20);
            this.lblCor.TabIndex = 10;
            this.lblCor.Text = "Cor";
            // 
            // FrmCarrosSalvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 458);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.cmbMarcaCarrosSalvar);
            this.Controls.Add(this.lblMarcasCarrosSalvar);
            this.Controls.Add(this.btnCarrosSalvar);
            this.Controls.Add(this.txtNomeCarrosSalvar);
            this.Controls.Add(this.lblNomeCarrosSalvar);
            this.Name = "FrmCarrosSalvar";
            this.Text = "Salvar Carros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarrosSalvar;
        private System.Windows.Forms.TextBox txtNomeCarrosSalvar;
        private System.Windows.Forms.Label lblNomeCarrosSalvar;
        private System.Windows.Forms.Label lblMarcasCarrosSalvar;
        private System.Windows.Forms.ComboBox cmbMarcaCarrosSalvar;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
    }
}
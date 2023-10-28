namespace Loja
{
    partial class FrmMarcasListar
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
            this.btnMarcasListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarcasListar
            // 
            this.btnMarcasListar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMarcasListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcasListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarcasListar.Location = new System.Drawing.Point(39, 32);
            this.btnMarcasListar.Name = "btnMarcasListar";
            this.btnMarcasListar.Size = new System.Drawing.Size(210, 57);
            this.btnMarcasListar.TabIndex = 3;
            this.btnMarcasListar.Text = "Listar";
            this.btnMarcasListar.UseVisualStyleBackColor = false;
            this.btnMarcasListar.Click += new System.EventHandler(this.btnMarcasListar_Click);
            // 
            // FrmMarcasListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 203);
            this.Controls.Add(this.btnMarcasListar);
            this.Name = "FrmMarcasListar";
            this.Text = "Listar Marcas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMarcasListar;
    }
}
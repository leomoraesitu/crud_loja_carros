using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.Class;

namespace Loja
{
    public partial class FrmMarcasSalvar : Form
    {
        public FrmMarcasSalvar()
        {
            InitializeComponent();
        }
        private void btnNome_Click(object sender, EventArgs e)
        {
            Marcas mar = new Marcas();
            mar.Marca = txtMarcasSalvar.Text;
            MessageBox.Show(Marcas.salvar(mar));
        }

        private void btnMarcasSalvar_Click(object sender, EventArgs e)
        {
            Marcas mar = new Marcas();
            mar.Id = 0;
            mar.Marca = txtMarcasSalvar.Text;
            MessageBox.Show(Marcas.salvar(mar));
        }
    }
}

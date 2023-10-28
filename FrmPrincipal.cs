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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ItemMarcasCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmMarcasSalvar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmMarcasSalvar>().First().Focus();
            }
            else
            {
                FrmMarcasSalvar frm = new FrmMarcasSalvar();
                frm.Show();
            }
        }

        private void ItemMarcasListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Marcas.listar());
        }

        private void ItemMarcasConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmMarcasListar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmMarcasListar>().First().Focus();
            }
            else
            {
                FrmMarcasListar frm = new FrmMarcasListar();
                frm.Show();
            }
        }

        private void ItemCarrosCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCarrosSalvar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCarrosSalvar>().First().Focus();
            }
            else
            {
                FrmCarrosSalvar frm = new FrmCarrosSalvar();
                frm.Show();
            }
        }

        private void ItemCarrosListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Carros.listar());
        }
    }
}

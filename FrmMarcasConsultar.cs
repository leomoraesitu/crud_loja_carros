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
    public partial class FrmMarcasConsultar : Form
    {
        public FrmMarcasConsultar()
        {
            InitializeComponent();
        }

        private void btnPesquisarMarcasConsultar_Click(object sender, EventArgs e)
        {
            Marcas mar = new Marcas();
            mar.Id = Int32.Parse(txtMarcasConsultar.Text);
            //txtMarcasConsultar.Text = Marcas.pesquisar(mar) ? mar.Marca : "Não encontrado!";

            if (Marcas.pesquisar(mar))
            {
                txtMarcasConsultar.BackColor = Color.White;
                txtMarcasConsultar.ForeColor = Color.Black;
                txtMarcasConsultar.Text = mar.Marca;
                btnExcluirMarcasConsultar.Enabled = true;
                btnEditarMarcasConsultar.Enabled = true;
                txtMarcasConsultar.ReadOnly = false;
            }
            else
            {
                txtMarcasConsultar.BackColor = Color.Red;
                txtMarcasConsultar.ForeColor = Color.White;
                txtMarcasConsultar.Text = "Não encontrado!";
                btnExcluirMarcasConsultar.Enabled = false;

            }
            txtIdMarcasConsultar.Focus();
        }

        private void btnExcluirMarcasConsultar_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir o registro?";
            string caption = "Exclusão de registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Marcas mar = new Marcas();
                MessageBox.Show(mar.excluir(txtIdMarcasConsultar.Text));

                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }

            limpar();
        }
        private void limpar()
        {
            txtIdMarcasConsultar.Clear();
            txtMarcasConsultar.Clear();
            txtIdMarcasConsultar.Focus();
            btnEditarMarcasConsultar.Enabled = false;
            btnExcluirMarcasConsultar.Enabled = false;
            txtMarcasConsultar.ReadOnly = true;
        }

        private void btnEditarMarcasConsultar_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente editar o registro?";
            string caption = "Edição de registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Marcas mar = new Marcas();
                mar.Id = Int32.Parse(txtIdMarcasConsultar.Text);
                mar.Marca = txtMarcasConsultar.Text;
                //MessageBox.Show(Marcas.editar(mar));
                MessageBox.Show(Marcas.salvar(mar));

                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }

            limpar();
        }

        private void btnCancelarMarcasConsultar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}

using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FrmCarrosSalvar : Form
    {
        public FrmCarrosSalvar()
        {
            InitializeComponent();

            MySqlDataReader res = Marcas.carregar();
            if (res.HasRows)
            {
                while (res.Read())
                {
                    cmbMarcaCarrosSalvar.Items.Add(res["id"].ToString() + " | " + res["marca"].ToString());
                }
            }
        }

        private void btnCarrosSalvar_Click(object sender, EventArgs e)
        {
            Carros c = new Carros();
            c.Modelo = txtNomeCarrosSalvar.Text;
            c.Ano = Int32.Parse(txtAno.Text);
            c.Cor = txtCor.Text;

            string[] marcasCarregar = cmbMarcaCarrosSalvar.SelectedItem.ToString().Split('|');
            c.Id_marca = Int32.Parse(marcasCarregar[0].Trim());

            MessageBox.Show(Carros.salvar(c));

            limpar();
        }
        private void limpar()
        {
            txtNomeCarrosSalvar.Clear();
            cmbMarcaCarrosSalvar.SelectedIndex = -1;
            txtNomeCarrosSalvar.Focus();
        }
    }
}

using Loja.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class FrmMarcasListar : Form
    {
        public FrmMarcasListar()
        {
            InitializeComponent();
        }

        private void btnMarcasListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Marcas.listar());
        }
    }
}

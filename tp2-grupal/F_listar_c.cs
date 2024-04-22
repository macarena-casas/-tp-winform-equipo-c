using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace tp2_grupal
{
    public partial class F_listar_c : Form
    {
        private List<Categoria> lista_Categoria;
        public F_listar_c()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F_listar_c_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            lista_Categoria = negocio.listar();
            dgv_Categoria.DataSource = lista_Categoria;
            

        }
    }
}

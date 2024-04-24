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
    public partial class FModificar_a : Form

    { 
        private List<Articulos> lista_articulos;

        public FModificar_a()
        {
            InitializeComponent();
        }

        private void b_cancel_ma_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FModificar_a_Load(object sender, EventArgs e)
        {
                ArticulosNegocio negocio = new ArticulosNegocio();
                lista_articulos = negocio.listar();
                dgv_modificar_a.DataSource = lista_articulos;
 

        }

        private void b_modif_a_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgv_modificar_a.CurrentRow.DataBoundItem;

            FAgregar_a modificar = new FAgregar_a(seleccionado);
        }
    }
}

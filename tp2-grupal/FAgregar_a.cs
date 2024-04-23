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
    public partial class FAgregar_a : Form
    {
        public FAgregar_a()
        {
            InitializeComponent();
        }

       


        private void tb_nombrea_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_nom_art_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A_agregar_A_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                art.codigo_articulo = tb_codigoa.Text;
                art.nombre_articulo = tb_nombrea.Text;
                //art.marca_articulo = (Marca) cb_marcas_a.SelectedItem;
               // art.categoria_articulo = (Categoria)cb_categorias_a.SelectedItem;
                art.descripcion_articulo = r_detalle_a.Text;
                art.precio_articulo = decimal.Parse(tb_precioa.Text) ;

                negocio.agregar(art);
                MessageBox.Show("Agregado con Exito");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FAgregar_a_Load(object sender, EventArgs e)
        {
            marca_negocio marcanegocio = new marca_negocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();
            try
            {
            cb_marcas_a.DataSource = marcanegocio.Listar();
            cb_categorias_a.DataSource = categorianegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
         
        }
    }
}

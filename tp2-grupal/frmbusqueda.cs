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
    public partial class frmbusqueda : Form
    {
        private List<Articulos> lista_articulos;
        public frmbusqueda()
        {
            InitializeComponent();
        }

        private void dvg_busqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmbusqueda_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscarid_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            lista_articulos = negocio.listarid((string)txt_buscarid.Text);

            try
            {
                if (lista_articulos != null)
                {
                    dgv_busqueda.DataSource = lista_articulos;
                    dgv_busqueda.Columns["imagen_a"].Visible = false;
                    cargarImagen(lista_articulos[0].imagen_a.Nombre_imagen);
                    rtb_Detalles.Text = lista_articulos[0].descripcion_a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("el id de articulo es incorrecto, intente nuevamente");

            }

        }

        private void btn_buscarco_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            lista_articulos = negocio.listarco((string)txt_buscarco.Text);
            try
            {
                if (lista_articulos!=null)
                {
                dgv_busqueda.DataSource = lista_articulos;
                dgv_busqueda.Columns["imagen_a"].Visible = false;
                cargarImagen(lista_articulos[0].imagen_a.Nombre_imagen);
                rtb_Detalles.Text = lista_articulos[0].descripcion_a;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("el codigo ingresado es invalido intente de nuevo");
                
            }
        }

        private void btn_buscarno_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            lista_articulos = negocio.listarno((string)txt_buscarno.Text);
            try
            {
                if (lista_articulos != null)
                {
                    dgv_busqueda.DataSource = lista_articulos;
                    dgv_busqueda.Columns["imagen_a"].Visible = false;
                    cargarImagen(lista_articulos[0].imagen_a.Nombre_imagen);
                    rtb_Detalles.Text = lista_articulos[0].descripcion_a;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("el nombre del articulo es invalido, intente de nuevo");

            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pb_Busqueda.Load(imagen);
                
            }
            catch (Exception ex)
            {
                pb_Busqueda.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }

        private void pb_Busqueda_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}

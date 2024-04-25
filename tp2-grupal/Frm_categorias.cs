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
    public partial class Frm_categorias : Form
    {
        public Frm_categorias()
        {
            InitializeComponent();
        } 
        public Frm_categorias(Categoria seleccionado)
        {
            InitializeComponent();
        }


        private void btn_listar_modi_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_listar_c))
                    return;
            }
            F_listar_c Flisc = new F_listar_c();
            Flisc.Show();
        }

        private void b_volver_c_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_agregar_c_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FAgregar_Categoria))
                    return;
            }
            FAgregar_Categoria Fagrec = new FAgregar_Categoria();
            Fagrec.Show();
        }

        private void b_eliminar_c_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            Categoria elim_Cate;
            int aux;

            try
            {
                DialogResult respuesta = MessageBox.Show("se eliminara la categoria seleccionada, ¿continuar?", "ELIMINAR CATEGORIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    /*elim_Cate = (Categoria)dgv_Categoria.CurrentRow.DataBoundItem;
                    aux = elim_Cate.codigo_categoria;
                    categoria.Eliminar(aux);
                    dgv_Categoria.DataSource = categoria.listar();*/
                }
                }
                
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

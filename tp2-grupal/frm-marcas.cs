using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2_grupal
{
    public partial class Frm_marcas : Form
    {
        public Frm_marcas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frm_agregarmarca))
                    return;
            }
            frm_agregarmarca FAgregar = new frm_agregarmarca();
            FAgregar.Show();

        }
        

        private void b_volve_m_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_listar_m_Click(object sender, EventArgs e)
        {

        }

        private void b_eliminar_m_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(frm_eliminarmarca))
                    return;
            }
            frm_eliminarmarca FEliminar = new frm_eliminarmarca();
            FEliminar.Show();
        }

        private void b_listar_m_Click_1(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frm_listarmarcas))
                    return;
            }
            frm_listarmarcas FListar = new frm_listarmarcas();
            FListar.Show();
        }
    }
}

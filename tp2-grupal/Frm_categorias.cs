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
    public partial class Frm_categorias : Form
    {
        public Frm_categorias()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void b_volver_c_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_agregar_c_Click(object sender, EventArgs e)
        {
            FAgregar_Categoria ventana = new FAgregar_Categoria();
            ventana.ShowDialog();
        }
    }
}

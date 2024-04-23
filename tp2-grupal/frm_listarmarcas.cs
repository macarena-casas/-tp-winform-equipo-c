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
    public partial class F_Listar_M : Form
    {
        public F_Listar_M()
        {
            InitializeComponent();
        }

        private void btn_salir_listarmarcas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F_Listar_M_Load(object sender, EventArgs e)
        {
            marca_negocio negocio = new marca_negocio();
            dgv_marcas.DataSource = negocio.Listar();
        }

        private void l_listarmarca_Click(object sender, EventArgs e)
        {

        }
    }
}

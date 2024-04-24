using negocio;
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
    public partial class F_listar_i : Form
    {
        public F_listar_i()
        {
            InitializeComponent();
        }

        private void dgv_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void F_listar_i_Load(object sender, EventArgs e)
        {
            imagen_negocio negocio = new imagen_negocio();
            dgv_listar.DataSource = negocio.Listar();
        }
    }
}

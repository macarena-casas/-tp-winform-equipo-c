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
    }
}

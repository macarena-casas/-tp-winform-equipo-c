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
    public partial class FArticulos : Form
    {
        public FArticulos()
        {
            InitializeComponent();
        }

        private void b_Detalles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("detalles");
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Close();
        }
    }
}

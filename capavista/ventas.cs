using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capalnegocio;

namespace capavista
{
    public partial class ventas : Form
    {

        private lnventa ventaLN = new lnventa();
        public ventas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ventaLN.LNnuevaVenta();

            ventaLN.LNdetalleVenta();
        }
    }
}

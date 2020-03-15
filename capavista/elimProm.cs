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
    public partial class elimProm : Form
    {
        public elimProm()
        {
            InitializeComponent();
        }


        private lnpromocion promocionLN = new lnpromocion();
        private lndetallepromo detallepromoLN = new lndetallepromo();

        private void elimProm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = promocionLN.buscarPromos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            if (txtCodProm.Text != "")
            {
                try
                {
                    int codPromo = Convert.ToInt32(txtCodProm.Text);
                   
                   promocionLN.eliminarPromocion(codPromo);
                    MessageBox.Show("Se ha eliminado con exito");
                    dataGridView1.DataSource = promocionLN.buscarPromos();
                    txtCodProm.Clear();
                    txtCodProm.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    throw;
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using System.Runtime.InteropServices; // para el movimiento del form

namespace capavista
{
    public partial class elimProm : Form
    {

        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            txtCodProm.Text = fila.Cells[0].Value.ToString();
        }

      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
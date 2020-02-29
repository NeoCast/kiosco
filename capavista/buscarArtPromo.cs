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
using System.Runtime.InteropServices;
using capasoporte.Cache;

namespace capavista
{

    public partial class buscarArtPromo : Form
    {
        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion
        public buscarArtPromo()
        {
            InitializeComponent();
        }

        private lnproducto productoLN = new lnproducto();

        private void buscarArtPromo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.kioscoDataSet.tipoProducto);
            dataGridView1.DataSource = productoLN.mostrarTodos();

            if (uCache.cargo == cargos.empleado)
            {
                dataGridView1.Columns[10].Visible = false;

            }
            if (uCache.cargo == cargos.administrador)
            {
                //codigo
            }
            txtBarra.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = productoLN.buscarPorTproducto(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw ex;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string codProd = addProd.Text.ToString();
            string descrip = addDesc.Text.ToString();
            string cant = addCant.Text.ToString();
            nuevapromocion form = Owner as nuevapromocion;
            form.txtCodProd.Text = codProd;
            form.txtDescripcion.Text = descrip;
            form.textBox1.Text = cant;
            this.Close(); 
            //Mando las variables como texto porque se pasan a un
            // textbox 

       


        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

   

        private void txtBarra_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

            string codBarra = Convert.ToString(txtBarra.Text);
               dataGridView1.DataSource = productoLN.mostrarProdBarra(codBarra);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            addProd.Text = fila.Cells[0].Value.ToString();
            addDesc.Text = fila.Cells[4].Value.ToString();
        }
    }
}

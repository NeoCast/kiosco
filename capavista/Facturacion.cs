using System;
using System.Windows.Forms;
using capalnegocio;

namespace capavista
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private lnventa ventaLN = new lnventa();
        private void Facturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.kioscoDataSet.tipoProducto);
            gridDetalles.DataSource = ventaLN.todoDetalleVta();
            comboBox1.Enabled = false;


        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Enabled == true)
                {
                    gridDetalles.DataSource = ventaLN.buscarPorTipoProducto(comboBox1.Text);
                }
                else
                {
                    gridDetalles.DataSource = ventaLN.LNbuscarDetalle(desdeFecha.Value, hastaFecha.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw;
            }
            

            
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            double cantidad = 0;
            try
            {
                foreach (DataGridViewRow fila in gridDetalles.Rows)
                {
                    cantidad = cantidad + Convert.ToDouble(fila.Cells[7].Value);

                }

                txtboxCalculo.Text = cantidad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw ex;
            }
       



        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }
    }
}

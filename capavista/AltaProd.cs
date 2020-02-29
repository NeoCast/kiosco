using System;
using System.Windows.Forms;
using capalnegocio;
using capasoporte.Cache;

namespace capavista
{
    public partial class AltaProd : Form
    {
        public AltaProd()
        {
            InitializeComponent();
        }

        private lnproducto productoLN = new lnproducto();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AltaProd_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.kioscoDataSet.tipoProducto);
            dateTimePicker1.Value = System.DateTime.Now;
            dateTimePicker2.Value = System.DateTime.Now;
            dataGridView1.DataSource = productoLN.mostrarTodos();
            txtBarra.Focus();

            if (uCache.cargo == cargos.empleado)
            {
                dataGridView1.Columns[9].Visible = false;
                txtCostos.Visible = false;
                label10.Visible = false;

            }
            if (uCache.cargo == cargos.administrador)
            {
                //codigo
            }


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Double costos = 0;
            try
            {

         
            if (txtstock.Text != "" && txtprecio.Text != "" && txtminimo.Text != "" && txtdescripcion.Text != "")

            {
                  if (txtCostos.Text != "")
                  {
                        costos = Convert.ToDouble(txtCostos.Text);
                  } 
                      productoLN.altaProducto(txtBarra.Text,comboBox1.Text, txtdescripcion.Text, Convert.ToDouble(txtprecio.Text), Convert.ToInt32(txtstock.Text), Convert.ToInt32(txtminimo.Text), dateTimePicker1.Value, dateTimePicker2.Value,costos);
                      MessageBox.Show("Producto guardado de manera exitosa");
                      dataGridView1.DataSource = productoLN.mostrarTodos();
                      txtdescripcion.Clear();
                      txtstock.Clear();
                      txtprecio.Clear();
                      txtminimo.Clear();
                      txtCostos.Clear();
                      txtdescripcion.Clear();
                      txtBarra.Clear();
            }
            
            else
            {
                MessageBox.Show("Por favor, complete todas las casillas");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw ex;
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }

        private void txtBarra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

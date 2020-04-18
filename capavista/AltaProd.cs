using System;
using System.Windows.Forms;
using capalnegocio;
using capasoporte;
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

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
                this.tipoProductoTableAdapter.Fill(this.kioscoDataSet.tipoProducto);
                dateTimePicker1.Value = System.DateTime.Now;
                dateTimePicker2.Value = System.DateTime.Now;
                dataGridView1.DataSource = productoLN.mostrarTodos();
                txtdescripcion.Focus();

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
            catch (Exception ex)
            {

                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
   


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Double costos = 0;
            try
            {
              
         
            if (txtstock.Text != String.Empty && txtprecio.Text != String.Empty && txtminimo.Text != String.Empty && txtdescripcion.Text != String.Empty)

            {
                  if (txtCostos.Text != "")
                  {
                        costos = Convert.ToDouble(txtCostos.Text);
                  }
                  //Creo el objeto de la clase productos
                  capaentidades.productos producto = new capaentidades.productos();
                  //Cargo el objeto producto
                  producto.tipoProducto = comboBox1.Text;
                  producto.descripcion = txtdescripcion.Text;
                  producto.precio = Convert.ToDouble(txtprecio.Text);
                  producto.stock = Convert.ToInt32(txtstock.Text);
                  producto.stockMin = Convert.ToInt32(txtminimo.Text);
                  producto.inFecha = dateTimePicker1.Value;
                  producto.outFecha = dateTimePicker2.Value;
                  producto.costos = costos;
                  //Mando el objeto al metodo para su proceso
                  productoLN.altaProducto(producto);

                      MessageBox.Show("Producto guardado de manera exitosa");
                      dataGridView1.DataSource = productoLN.mostrarTodos();
                      txtdescripcion.Clear();
                      txtstock.Clear();
                      txtprecio.Clear();
                      txtminimo.Clear();
                      txtCostos.Clear();
                      txtdescripcion.Clear();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

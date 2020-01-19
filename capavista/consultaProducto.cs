using capalnegocio;
using System;
using System.Windows.Forms;

namespace capavista
{
    public partial class consultaProducto : Form
    {
        public consultaProducto()
        {
            InitializeComponent();
        }

        private lnproducto productoln = new lnproducto();


        private void Consultas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.kioscoDataSet.tipoProducto);

            dataGridView1.DataSource = productoln.mostrarTodos();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idProd, stock, stockmin;
            string tproducto, descripcion;
            double precio;

            idProd = Convert.ToInt32(txtidproducto.Text);
            stock = Convert.ToInt32(textBox3.Text);
            stockmin = Convert.ToInt32(textBox5.Text);
            tproducto = Convert.ToString(comboBox1.SelectedValue);
            descripcion = Convert.ToString(textBox2.Text);
            precio = Convert.ToDouble(textBox4.Text);

            productoln.modificarProducto(idProd, tproducto, descripcion, precio, stock, stockmin);
            MessageBox.Show("se ha modificado con exito");
            productoln.mostrarTodos();
        }


        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];


            //string format = string.Format("dd-MM-yyyy HH:mm:ss");
            //DateTime fecha = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            //DateTime fecha2 = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());

            //fecha.ToString(format);
            //fecha2.ToString(format);



            txtidproducto.Text = fila.Cells[0].Value.ToString();
            comboBox1.Text = fila.Cells[2].Value.ToString();
            textBox2.Text = fila.Cells[3].Value.ToString();
            textBox3.Text = fila.Cells[4].Value.ToString();
            textBox5.Text = fila.Cells[5].Value.ToString();
            textBox4.Text = fila.Cells[6].Value.ToString();
        }

        private void BtnElim_Click(object sender, EventArgs e)
        {
            if (txtidproducto.Text != " ")
            {

                int idProd = Convert.ToInt32(txtidproducto.Text);

                productoln.eliminarProducto(idProd);
                MessageBox.Show("Se ha eliminado con exito");
                productoln.mostrarTodos();

            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string descripcion = Convert.ToString(textBox1.Text);
            dataGridView1.DataSource=  productoln.mostrarProductos(descripcion);
        }
    }
}


using capalnegocio;
using System;
using System.Windows.Forms;
using capasoporte.Cache;

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
            textBox1.Focus();


            if (uCache.cargo == cargos.empleado)
            {
                dataGridView1.Columns[10].Visible = false;
                textBox6.Visible= false;
                label6.Visible = false;
            }
            if (uCache.cargo == cargos.administrador)
            {
                //codigo
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                int idProd, stock, stockmin;
                string tproducto, descripcion,codBarra;
                double precio, costos=0;

                if (textBox6.Text != "")
                {
                    costos = Convert.ToDouble(textBox6.Text);
                }


                idProd = Convert.ToInt32(txtidproducto.Text);
                codBarra = Convert.ToString(txtBarra.Text);
                stock = Convert.ToInt32(textBox3.Text);
                stockmin = Convert.ToInt32(textBox5.Text);
                tproducto = Convert.ToString(comboBox1.SelectedValue);
                descripcion = Convert.ToString(textBox2.Text);
                precio = Convert.ToDouble(textBox4.Text);
                costos = Convert.ToDouble(textBox6.Text);

                productoln.modificarProducto(idProd,codBarra, tproducto, descripcion, precio, stock, stockmin, costos);
                MessageBox.Show("se ha modificado con exito");
                dataGridView1.DataSource = productoln.mostrarTodos();
                txtidproducto.Clear();
                comboBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox1.Clear();
                txtBarra.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw ex;
            }
            
        }
        private void BtnElim_Click(object sender, EventArgs e)
        {
            if (txtidproducto.Text != "")
            {
                try
                {
                    int idProd = Convert.ToInt32(txtidproducto.Text);

                    productoln.eliminarProducto(idProd);
                    MessageBox.Show("Se ha eliminado con exito");
                    dataGridView1.DataSource = productoln.mostrarTodos();
                    txtidproducto.Clear();
                    comboBox1.Text = "";
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox1.Clear();
                    txtBarra.Clear();
                    textBox1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    throw;
                }
               
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
            string codBarra = Convert.ToString(textBox1.Text);
            dataGridView1.DataSource = productoln.mostrarProductos(codBarra,descripcion);

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
            txtBarra.Text = fila.Cells[1].Value.ToString();
            comboBox1.Text = fila.Cells[3].Value.ToString();
            textBox2.Text = fila.Cells[4].Value.ToString();
            textBox3.Text = fila.Cells[5].Value.ToString();
            textBox5.Text = fila.Cells[6].Value.ToString();
            textBox4.Text = fila.Cells[7].Value.ToString();
            textBox6.Text = fila.Cells[10].Value.ToString();


          
        
          
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string descripcion = Convert.ToString(textBox1.Text);
            string codBarra = Convert.ToString(textBox1.Text);
            dataGridView1.DataSource = productoln.mostrarProductos(codBarra,descripcion);

            // quiero poner lo de abrir con lo del click automatic

            txtidproducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBarra.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();






        }
    }
}


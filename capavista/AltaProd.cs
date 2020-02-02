using System;
using System.Windows.Forms;
using capalnegocio;

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
            txtdescripcion.Focus();


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

           
            if (txtstock.Text != "" && txtprecio.Text != "" && txtminimo.Text != "" && txtCostos.Text != "" && txtdescripcion.Text != "")
            {
                  productoLN.altaProducto(comboBox1.Text, txtdescripcion.Text, Convert.ToDouble(txtprecio.Text), Convert.ToInt32(txtstock.Text), Convert.ToInt32(txtminimo.Text), dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToDouble(txtCostos.Text));
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

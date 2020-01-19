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


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Text != " " )
            {
                productoLN.altaProducto(comboBox1.SelectedItem.ToString(), txtdescripcion.Text, Convert.ToDouble(txtprecio.Text), Convert.ToInt32(txtstock.Text), Convert.ToInt32(txtminimo.Text), dateTimePicker1.Value, dateTimePicker2.Value);
                MessageBox.Show("Producto guardado de manera exitosa");
                dataGridView1.DataSource = productoLN.mostrarTodos();

            }
            else
            {
                MessageBox.Show("Por favor ingrese la descripcion del producto");
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

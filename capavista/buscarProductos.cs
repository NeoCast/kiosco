using capalnegocio;
using System;
using System.Windows.Forms;

namespace capavista
{
    public partial class buscarProductos : Form
    {
        public buscarProductos()
        {
            InitializeComponent();
        }

        private lnproducto productoln = new lnproducto();

        private void ProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kioscoDataSet);


        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productoln.mostrarTodos();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{


        //    if (textBox1.Text != "")
        //    {
        //        dataGridView1.DataSource = productoln.mostrarProductos(textBox1.Text);
        //    }
        //    else
        //    {
        //        dataGridView1.DataSource = productoln.mostrarTodos();


        //    }
       // }
    }
}

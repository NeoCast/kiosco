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

        private void Button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text != "")
            {
                productoln.mostrarProductos(textBox1.Text);
            }
            else
            {
                dataGridView1.DataSource = productoln.mostrarTodos();


            }
        }
    }
}

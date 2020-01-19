using System;
using System.Windows.Forms;

namespace capavista
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void BtnNuevoProd_Click(object sender, EventArgs e)
        {
            nuevoProducto formNuevo = new nuevoProducto();
            formNuevo.Show();

        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            buscarProductos formNuevo = new buscarProductos();
            formNuevo.Show();
        }
    }
}

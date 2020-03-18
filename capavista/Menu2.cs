using System;
using System.Windows.Forms;
using capalnegocio;

namespace capavista
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private lnpromocion promocion = new lnpromocion();
        private lnproducto producto = new lnproducto();

        private void Menu2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = promocion.buscarPromos();
            dataGridView2.DataSource = producto.mostrarPorVenc();
        }

        private void btnMasDetalles_Click(object sender, EventArgs e)
        {
         masProm prom = new masProm();
            prom.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCont2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

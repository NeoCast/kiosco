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

        private void Menu2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= promocion.buscarPromos();
        }
    }
}

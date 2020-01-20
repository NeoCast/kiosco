using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capavista
{

 
    public partial class nuevapromocion : Form
    {
        public nuevapromocion()
        {
            InitializeComponent();
        }


        private void promociones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.kioscoDataSet.productos);

        }

      

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgProm_Click(object sender, EventArgs e)
        {

        }
    }
}

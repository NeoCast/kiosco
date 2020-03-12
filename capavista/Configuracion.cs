using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capasoporte.Cache;
using capalnegocio;

namespace capavista
{
    public partial class Configuracion : Form
    {

        public Configuracion()
        {
            InitializeComponent();
            dataGridView1.DataSource = usuarioLN.mostrarTodos();
        }


        private lnusuario usuarioLN = new lnusuario();

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txbUsu.Text != "")
                {
                if (txbCont.Text != "")
                {
                    if (txbNomb.Text != "")
                    {
                        if (txbCargo.Text != "")
                        {
                            usuarioLN.altaUsuario(txbUsu.Text, txbCont.Text, txbNomb.Text, txbCargo.Text);
                            MessageBox.Show("Usuario guardado de manera exitosa");
                            dataGridView1.DataSource = usuarioLN.mostrarTodos();
                            txbUsu.Clear();
                            txbCont.Clear();
                            txbNomb.Clear();
                        }
                    }
                }
              
            }
            else
            {
                MessageBox.Show("Por favor, complete todas las casillas");
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            if (txbElim.Text != "")
            {
                int codUsu = Convert.ToInt32(txbElim.Text);
                usuarioLN.eliminarUsu(codUsu);
                MessageBox.Show("Se ha eliminado con exito");
                dataGridView1.DataSource = usuarioLN.mostrarTodos();
                txbElim.Clear();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un usuario");
            }
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
   
}

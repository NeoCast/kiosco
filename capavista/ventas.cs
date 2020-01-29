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
    public partial class ventas : Form
    {
        private lnproducto productoLN = new lnproducto();
        private lnventa ventaLN = new lnventa();
        public ventas()
        {
            InitializeComponent();
        }
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
         

                int cantfila = dataGridView1.Rows.Count;
                foreach (DataGridViewRow fila in gridDetalles.Rows)
                {



                    if (fila != null)
                    {
                            if (fila.Index < cantfila - 1)
                            {
                                int codProd = Convert.ToInt32(fila.Cells[0].Value.ToString());
                                string descripcion = Convert.ToString(fila.Cells[1].Value.ToString());
                                
                                int cantidad = Convert.ToInt32(fila.Cells[4].Value.ToString());

                                //ventaLN.LNnuevaVenta();

                                //ventaLN.LNdetalleVenta(codProd, cantidad, descripcion, );
                    
                            }
                             else
                                {
                                    MessageBox.Show("la fila es nula");

                                }

                    }
                    //else if (fila = -1)
                    //{

                    //}

                    //    }

                   

                }

            MessageBox.Show("La carga se realizo con exito");



        }
         
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

       
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productoLN.mostrarTodos();
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {

                // Creamos un array con los valores que vamos a insertar
                // en el segundo control DataGridView.
                //

                object[] values = {

                                          fila.Cells["codProd"].Value,
                                          fila.Cells["tProducto"].Value,
                                          fila.Cells["descripcion"].Value,
                                          fila.Cells["cantidad"].Value,
                                          fila.Cells["valor"].Value,
                                          fila.Cells["valorTotal"].Value


                                  };

                // Creamos un nuevo objeto DataGridViewRow.
                //
                DataGridViewRow row = new DataGridViewRow();

                // Creamos las celdas y las rellenamos con los valores existentes
                // en el array.
                //
                row.CreateCells(gridDetalles, values);

                // Añadimos la nueva fila al segundo control DataGridView.
                //
                gridDetalles.Rows.Add(row);

            }
        }
    }
}

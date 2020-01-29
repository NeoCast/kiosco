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
            if (label3.Text != "")
            {
                double total = Convert.ToDouble(label3.Text);

                int cantfila = dataGridView1.Rows.Count;
                if (cantfila > 0)
                {
                    ventaLN.LNnuevaVenta(total, System.DateTime.Now);

                    foreach (DataGridViewRow fila in gridDetalles.Rows)
                    {

                        if (fila != null)
                        {
                            if (fila.Index < cantfila - 1)
                            {
                                int codProd = Convert.ToInt32(fila.Cells[0].Value.ToString());
                                string tipoProd = Convert.ToString(fila.Cells[1].Value.ToString());
                                string descripcion = Convert.ToString(fila.Cells[2].Value.ToString());
                                int cantidad = Convert.ToInt32(fila.Cells[3].Value.ToString());
                                double precio = Convert.ToDouble(fila.Cells[4].Value.ToString());
                                double totalProd = Convert.ToDouble(fila.Cells[5].Value.ToString());


                                //ventaLN.LNdetalleVenta(codProd, cantidad, descripcion, );

                            }
                        }
                        else
                        {
                            MessageBox.Show("la fila es nula");
                        }
                        //else if (fila = -1)
                        //{

                        //}

                        //    }
                    }


                }

                MessageBox.Show("La carga se realizo con exito");

            }
            else
            {
                MessageBox.Show("Por favor ingrese algun producto antes de realizar la venta");
            }




        }
         
 

        private void Ventas_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = productoLN.mostrarTodos();


        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow fila = new DataGridViewRow();
            DataGridViewRow fila2 = new DataGridViewRow();
            int cantidad;
            double precio, totalProd;


           

                fila = dataGridView1.SelectedRows[e.RowIndex];
            cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("ingrese la cantidad: ").ToString());
       
                try
                {
               
                precio = Convert.ToDouble(fila.Cells);
                totalProd = precio * cantidad;
                    fila2.CreateCells(gridDetalles);
                    fila2.Cells[0].Value = fila.Cells[0].Value;
                    fila2.Cells[1].Value = fila.Cells[1].Value;
                    fila2.Cells[2].Value = fila.Cells[2].Value;
                    fila2.Cells[3].Value = cantidad;
                    fila2.Cells[4].Value = fila.Cells[3].Value;
                    fila2.Cells[5].Value = totalProd;
                    
                gridDetalles.Rows.Add(fila);

                label3.Text = Convert.ToString(Convert.ToDouble(label3.Text) + totalProd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("selecciona una fila para realizar ésta accion");
                    throw ex;
                }

            




        }

    }
    
}

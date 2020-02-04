﻿using System;
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
          //  fila = dataGridView1.CurrentRow;


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                int codProd;
                int codPromo;
                string tipoProd;
                string descripcion;
                int cantidad;
                double precio;
                double total = Convert.ToDouble(label3.Text);

                int cantfila = dataGridView1.Rows.Count;
                if (cantfila > 0)
                {
                    try
                    {
                        ventaLN.LNnuevaVenta(total, System.DateTime.Now);
                        //fila = null
                        foreach (DataGridViewRow fila in gridDetalles.Rows)
                        {

                            if (fila != null)
                            {
                                if (fila.Index < cantfila - 1 && cantfila != 4)
                                {
                                    if (fila.Cells[1].Value.ToString() == "" || fila.Cells[1].Value == null)
                                    {

                                        codPromo = 0;

                                    }
                                    else
                                    {

                                        codPromo = Convert.ToInt32(fila.Cells[1].Value.ToString());

                                    }

                                    codProd = Convert.ToInt32(fila.Cells[0].Value.ToString());
                                    tipoProd = Convert.ToString(fila.Cells[2].Value.ToString());
                                    descripcion = Convert.ToString(fila.Cells[3].Value.ToString());
                                    cantidad = Convert.ToInt32(fila.Cells[4].Value.ToString());
                                    precio = Convert.ToDouble(fila.Cells[5].Value.ToString());
                                    double totalProd = Convert.ToDouble(fila.Cells[6].Value.ToString());


                                    ventaLN.LNdetalleVenta(codProd, tipoProd, codPromo, cantidad, descripcion, totalProd, System.DateTime.Now);
                                    dataGridView1.DataSource = productoLN.mostrarTodos();
                                }
                            }
                            else
                            {
                                MessageBox.Show("la fila es nula");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                        throw;
                    }
                    


                }

                MessageBox.Show("La venta se realizo con exito");
                gridDetalles.Rows.Clear();

            }
            else
            {
                MessageBox.Show("Por favor ingrese algun producto antes de realizar la venta");
            }




        }
         
 

        private void Ventas_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = productoLN.mostrarTodos();
            label3.Text = "0";

        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            DataGridViewRow fila2 = new DataGridViewRow();
            int cantidad;
            double precio, totalProd;
            string resultado = Microsoft.VisualBasic.Interaction.InputBox("ingrese la cantidad: ").ToString();
            DataGridViewRow fila = new DataGridViewRow();
            fila = dataGridView1.CurrentRow;
            if (resultado.Length > 0)
            {


                cantidad = Convert.ToInt32(resultado);

                try
                {
                    //fila.DataGridView.SelectedRows[] = dataGridView1.SelectedRows[e.RowIndex];
                    precio = Convert.ToDouble(fila.Cells[6].Value.ToString());
                    totalProd = precio * cantidad;

                    fila2.CreateCells(gridDetalles);

                    fila2.Cells[0].Value = fila.Cells[0].Value.ToString();
                    fila2.Cells[1].Value = fila.Cells[1].Value.ToString();
                    fila2.Cells[2].Value = fila.Cells[2].Value.ToString();
                    fila2.Cells[3].Value = fila.Cells[3].Value.ToString();
                    fila2.Cells[4].Value = cantidad.ToString();
                    fila2.Cells[5].Value = fila.Cells[6].Value.ToString();
                    fila2.Cells[6].Value = totalProd.ToString();

                    gridDetalles.Rows.Add(fila2);


                    //gridDetalles = new DataGridView();
                    //gridDetalles.Rows.Add(fila.Cells[0].RowIndex, fila.Cells[1].RowIndex, fila.Cells[2].RowIndex, cantidad, fila.Cells[3].RowIndex, fila.Cells[4].RowIndex, fila.Cells[6].RowIndex);

                    label3.Text = Convert.ToString(Convert.ToDouble(label3.Text) + totalProd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("selecciona una fila para realizar ésta accion");
                    return;
                    throw ex;
                }
            }

        }

        private void BtnEliminarDetalle_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila = gridDetalles.CurrentRow;

            gridDetalles.Rows.Remove(fila);


        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = productoLN.mostrarProductos(txbBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw;
            }
           
        }
    }
    
}

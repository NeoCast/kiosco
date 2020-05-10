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

 
    public partial class nuevapromocion : Form
    {
        public nuevapromocion()
        {
            InitializeComponent();
        }
        //public nuevapromocion(string codProd, string descrip, string cant)
        //{

        //    InitializeComponent();
        //    txtCodProd.Text = codProd.ToString();
        //    txtDescr.Text = descrip.ToString();
        //    textBox1.Text = cant.ToString();

        //}


        private lnpromocion promocionLN = new lnpromocion();
        private lndetallepromo detallepromoLN = new lndetallepromo();
        private lnpromocion PromcomboLN = new lnpromocion();
        private DataGridViewRow fila = new DataGridViewRow();

        private void nuevapromocion_Load(object sender, EventArgs e)

        {       
          
        }
        private void promociones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.kioscoDataSet.productos);
          
        }

     

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int cant, codProd;

            if (textBox1.Text != "" && txtCodProd.Text != "" && txtCodProd.Text != "")
            {
                        cant = Convert.ToInt32(textBox1.Text);
                        codProd = Convert.ToInt32(txtCodProd.Text);
                        dataGridView1.Rows.Add(codProd, txtDescripcion.Text, cant);
                txtCodProd.Clear();
                txtDescripcion.Clear();
                textBox1.Clear();
            }   
           
          
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int indice;
            try
            {
                indice = dataGridView1.CurrentRow.Index;

                dataGridView1.Rows.RemoveAt(indice);
                
            }
            catch (Exception ex)
            {
                if (dataGridView1.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Por favor ingrese un producto antes de eliminar");
                }
                else
                {
                    throw ex;
                }
                

            }
            

        }

        private void BtnAgProm_Click(object sender, EventArgs e)
        {




            try
            {

                capaentidades.promocion promo = new capaentidades.promocion();
                capaentidades.detallePromocion dtPromo = new capaentidades.detallePromocion();
                
              

                if (txtDescr.Text != "" && txtTotal.Text != "")
                {

                    promo.total = Convert.ToDouble(txtTotal.Text);
                    promo.descrPromo = txtDescr.Text;
                    promo.cantidad = Convert.ToInt32(textBox1.Text);
                    promocionLN.nuevaPromo(promo);
                }

                int cantfila = dataGridView1.Rows.Count;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {



                    if (fila != null)
                    {
                        if (fila.Index < cantfila - 1)
                        {

                            dtPromo.codProd = Convert.ToInt32(fila.Cells[0].Value.ToString());
                            dtPromo.descriProd = Convert.ToString(fila.Cells[1].Value.ToString());
                            dtPromo.cantidad = Convert.ToInt32(fila.Cells[2].Value.ToString());
                            detallepromoLN.nuevoDetallePromo(dtPromo);
                         

                        }
                    }
                    //else if (fila = -1)
                    //{

                    //}

                }

                MessageBox.Show("La carga se realizo con exito");
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {

                throw ex;

            }



            //---------------------CODIGO PARA REARMAR VUELTO A VERSION ANTERIOR PARA DEPLOY WEB ----------
            //try
            //{
            //    capaentidades.promocion promo = new capaentidades.promocion();
            //    capaentidades.detallePromocion dtPromo = new capaentidades.detallePromocion();
            //    DataTable tabla = new DataTable();
            //    tabla.Rows.Add(dataGridView1.Rows);
            //    if (tabla.Rows != null || tabla.Rows.Count > 0)
            //    {

            //    }
            //    if (txtDescr.Text != "" && txtTotal.Text != "")
            //    {
            //        promo.descrPromo = txtDescr.Text;
            //        promo.total = Convert.ToDouble(txtTotal.Text);
            //        promo.activo = 1;
            //        promocionLN.nuevaPromo(promo);
            //    }
            //    //              TOMO LA CANTIDAD DE FILAS PARA RECORRER DATAGRIDVIEW
            //    int cantfila = dataGridView1.Rows.Count;
            //    //              RECORRO LAS FILAS
            //    foreach (DataGridViewRow fila in dataGridView1.Rows)
            //    {



            //        if (fila != null )
            //        {
            //            if (fila.Index < cantfila-1)
            //            {
            //                //cargo la entidad con sus datos
            //                //para su posterior envio
            //                dtPromo.codProd = Convert.ToInt32(fila.Cells[0].Value.ToString());
            //                dtPromo.descriProd = Convert.ToString(fila.Cells[1].Value.ToString());
            //                dtPromo.cantidad = Convert.ToInt32(fila.Cells[2].Value.ToString());
            //                detallepromoLN.nuevoDetallePromo(dtPromo);

            //            }
            //        }

            //    }

            //    MessageBox.Show("La carga se realizo con exito");
            //    dataGridView1.Rows.Clear();

            //}
            //catch (Exception ex)
            //{

            //    throw ex;

            //}


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void codProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarArtPromo form = new buscarArtPromo();
            AddOwnedForm(form);
            form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDescr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            elimProm elim = new elimProm();
            elim.ShowDialog();
        }
    }
}

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

            if (textBox1.Text != "")
            {
                if (txtCodProd.Text != "")
                {
                    if (txtCodProd.Text != "")
                    {
                        cant = Convert.ToInt32(textBox1.Text);
                        codProd = Convert.ToInt32(txtCodProd.Text);
                        dataGridView1.Rows.Add(codProd, txtCodProd.Text, cant);
                    }
                   

                }
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
                if (txtDescr.Text != "" && txtTotal.Text != "")
                {
                    double total = Convert.ToDouble(txtTotal.Text);
                    int activo = 1;
                    promocionLN.nuevaPromo(txtDescr.Text, total, activo);
                    MessageBox.Show("La nueva promocio se ha guardado con exito");
                }

                int cantfila = dataGridView1.Rows.Count;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {

                        
                
                    if (fila != null )
                    {
                        if (fila.Index < cantfila-1)
                        {
                            int codProd = Convert.ToInt32(fila.Cells[0].Value.ToString());
                            string descripcion = Convert.ToString(fila.Cells[1].Value.ToString());
                            int cantidad = Convert.ToInt32(fila.Cells[2].Value.ToString());
                            detallepromoLN.nuevoDetallePromo(codProd, descripcion, cantidad);
                        }
                    }
                    //else if (fila = -1)
                    //{

                    //}

                }

                MessageBox.Show("La carga se realizo con exito");

            }
            catch (Exception ex)
            {

                throw ex;

            }
           

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
            form.ShowDialog();
        }
    }
}

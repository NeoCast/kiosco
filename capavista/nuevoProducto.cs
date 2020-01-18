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
    public partial class nuevoProducto : Form
    {
        private lnproducto productoLN = new lnproducto();
        private DataTable tabla = new DataTable();


        public nuevoProducto()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {


            
            int stock, stockmin;
            String descripcion, tproducto;
            Double precio;
            stock = Convert.ToInt32(txtstock.Text);
            stockmin = Convert.ToInt32(txtmin.Text);
            precio = Convert.ToDouble(txtprecio.Text);
            descripcion = txtdescripcion.Text;
            tproducto = combotproducto.Text;
            

            
                if ((txtdescripcion.Text != "" && precio > 0.00) && (stock > 0 && stockmin > 0))
                {

                   
                   
                        productoLN.altaProducto(tproducto, descripcion, precio, stock, stockmin, dateTimePicker1.Value, dateTimePicker2.Value);
                        MessageBox.Show("Producto agregado correctamente");
                        dataGridView1.Rows.Add(descripcion);
                                        
                }


            
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.kioscoDataSet.tipoProducto);

            dateTimePicker1.Value = System.DateTime.Now;
            dateTimePicker2.Value = System.DateTime.Now;

        }
    }
}

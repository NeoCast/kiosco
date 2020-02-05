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
    public partial class buscarArtPromo : Form
    {
        public buscarArtPromo()
        {
            InitializeComponent();
        }

        private lnproducto productoLN = new lnproducto();

        private void buscarArtPromo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.kioscoDataSet.tipoProducto);
            dataGridView1.DataSource = productoLN.mostrarTodos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = productoLN.buscarPorTproducto(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la accion. Error: " + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw ex;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string codProd = addProd.Text.ToString();
            string descrip = addDesc.Text.ToString();
            string cant = addCant.Text.ToString();
            nuevapromocion form = Owner as nuevapromocion;
            form.txtCodProd.Text = codProd;
            form.txtDescripcion.Text = descrip;
            form.textBox1.Text = cant;
            this.Close(); 
            //Mando las variables como texto porque se pasan a un
            // textbox 

       


        }
    }
}

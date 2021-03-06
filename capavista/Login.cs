﻿using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using capalnegocio;
using System.Data;
using Microsoft.VisualBasic;


namespace capavista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       private lnSerial vs = new lnSerial();

        public bool compruebaSerial()
        {
            bool Verificado = false;

           
            string SerialGenerado;
            string SerialGuardado;

            vs.GetCpuID();
            vs.GetMacAddress();
            vs.GetMotherBoardID();


            if (File.Exists("verificador.xml") == false)
            {
                // File.Create("verificador.xml").Dispose()

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                // Create XmlWriter.
                using (XmlWriter writer = XmlWriter.Create("verificador.xml", settings))
                {
                    // Begin writing.
                    writer.WriteStartDocument();
                    writer.WriteStartElement("VerificadorSeriales"); // Root.

                    writer.WriteStartElement("serialinfo");
                    writer.WriteElementString("serial", "12345");
                    writer.WriteEndElement();

                    // End document.
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }

            string myXMLfile = "verificador.xml";
            System.IO.FileStream fsReadXml = new System.IO.FileStream(myXMLfile, System.IO.FileMode.Open);

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(fsReadXml);

                SerialGuardado = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                SerialGenerado = lnSerial.GenerarSerial(vs.cpuInfo + vs.macaddress + vs.strMotherBoardID);

                fsReadXml.Close();

                if (SerialGuardado == SerialGenerado)
                    Verificado = true;
                else
                {
                    string serial = SerialGuardado;

                    if (MessageBox.Show("No ha registrado un serial o el que tiene es inválido ¿Desea introducir el serial ahora?", "Serial Incorrecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) is DialogResult vbYes)
                    {
                        serial = Microsoft.VisualBasic.Interaction.InputBox("Inserte el serial para continuar", "Serial incorrecto");

                        if (serial == SerialGenerado)
                        {
                            Verificado = true;

                            // Create XmlWriterSettings.
                            XmlWriterSettings settings = new XmlWriterSettings();
                            settings.Indent = true;

                            // Create XmlWriter.
                            using (XmlWriter writer = XmlWriter.Create("verificador.xml", settings))
                            {
                                // Begin writing.
                                writer.WriteStartDocument();
                                writer.WriteStartElement("VerificadorSeriales"); // Root.

                                writer.WriteStartElement("serialinfo");
                                writer.WriteElementString("serial", serial);
                                writer.WriteEndElement();

                                // End document.
                                writer.WriteEndElement();
                                writer.WriteEndDocument();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Lo sentimos, no puede acceder sin haber registrado este software!", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return Verificado;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                fsReadXml.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(compruebaSerial()) == false)
            {
                if (txtUsu.Text != "")
                {
                    if (txtCont.Text != "")
                    {
                        lnusuario lusuario = new lnusuario();
                        var loginvalido = lusuario.loginuser(txtUsu.Text, txtCont.Text);
                        if(loginvalido==true)
                        {
                            Bienvenida bienvenida = new Bienvenida();
                            bienvenida.Show();
                            this.Hide();
                        }
                        else
                        {
                            msgError("Los valores ingresados son incorrectos");
                            txtUsu.Clear();
                            txtCont.Clear();
                            txtUsu.Focus();
                        }

                    }
                    else msgError("Por favor ingrese su contraseña");
                }

                else msgError("Por favor ingrese su nombre de usuario");

            }
          
        }
        private void msgError(string msg)
        {
            lblerror.Text = "" + msg;
            lblerror.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                if (txtCont.PasswordChar=='*')
                {
                    txtCont.PasswordChar = '\0';
                }
            }
            else
            { txtCont.PasswordChar = '*'; }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (!(compruebaSerial()) == false)
                {
                    if (txtUsu.Text != "")
                    {
                        if (txtCont.Text != "")
                        {
                            lnusuario lusuario = new lnusuario();
                            var loginvalido = lusuario.loginuser(txtUsu.Text, txtCont.Text);
                            if (loginvalido == true)
                            {
                                Bienvenida bienvenida = new Bienvenida();
                                bienvenida.Show();
                                this.Hide();
                            }
                            else
                            {
                                msgError("Los valores ingresados son incorrectos");
                                txtCont.Clear();
                                txtUsu.Focus();
                            }

                        }
                        else msgError("Por favor ingrese su contraseña");
                    }
                    else msgError("Por favor ingrese su nombre de usuario");

                }
                //        If compruebaSerial() = False Then
                //Else
                //        If txtUsuario.Text = "admin" And txtClave.Text = "123" Then
                //            Form1.Show()
                //            Me.Hide()
                //        Else
                //            MsgBox("Usuario o Clave incorrecta")
                //        End If

                //    End If
            }

        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
 
        }
       

    }
}

using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using capalnegocio;
using System.Data;
using Microsoft.VisualBasic;
using capaentidades;


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
            int esVerificado = 0;
            int primeraVez = 0;
            psver serialInfo = new psver();
            lnSerial serialLN = new lnSerial();
            

            string SerialGenerado;
            string SerialGuardado;

            vs.GetCpuID();
            vs.GetMacAddress();
            vs.GetMotherBoardID();
            try
            {

            serialInfo = serialLN.comprobarInstall();
            SerialGenerado = lnSerial.GenerarSerial(vs.cpuInfo + vs.macaddress + vs.strMotherBoardID);
                //Pregunta si existe controlador
                //if (File.Exists("verificador.xml") == false)
                //{
                esVerificado = serialInfo.num_i;
                if (serialInfo.valStr != SerialGenerado)
                {


                    primeraVez = serialInfo.pvez;
                    if (primeraVez == 0)
                    {
                        MessageBox.Show("Por favor pongase en contacto con FastCheckSoft para reanudar su licencia");
                        return false;
                    }
                }     
            switch (esVerificado)
            {
                case 1:
                    // File.Create("verificador.xml").Dispose()

                   
                    serialLN.modificarInstall(serialInfo, 11, SerialGenerado);

                    break;
                case 2:
               
                   
                    serialLN.modificarInstall(serialInfo, SerialGenerado);
                    
                    break;
                case 3:
                    break;
                case 11:
                    
                case 13:
                        SerialGenerado = lnSerial.GenerarSerial(vs.cpuInfo + vs.macaddress + vs.strMotherBoardID);
                        Verificado = true;
                        
                break;

                case 12:
                    serialInfo = serialLN.comprobarFecha(serialInfo);
                    serialLN.modificarInstall(serialInfo, serialInfo.valStr);
                    break;
                default:
                    MessageBox.Show("Por favor contactese con nosotros para renovar su suscripcion. /br Atentamente FastCheck");
                    break;
                 }
             }
        

            catch (Exception ex)
            {
               // Application.Exit();
                throw ex;
                return Verificado = false;
            }
            //string myXMLfile = "verificador.xml";
            //System.IO.FileStream fsReadXml = new System.IO.FileStream(myXMLfile, System.IO.FileMode.Open);

            try
            {
                DataSet ds = new DataSet();
                //ds.ReadXml(fsReadXml);

                SerialGuardado = serialInfo.valStr;
                SerialGenerado = lnSerial.GenerarSerial(vs.cpuInfo + vs.macaddress + vs.strMotherBoardID);

                //fsReadXml.Close();

                if (SerialGuardado == SerialGenerado)
                {     
                    Verificado = true;
                }
                else
                {
                    string serial = SerialGuardado;
                    //              -----------------SERIAL MODIFICADO 03/05/2020-----------------
                    //if (MessageBox.Show("No ha registrado un serial o el que tiene es inválido ¿Desea introducir el serial ahora?", "Serial Incorrecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) is DialogResult vbYes)
                    //{
                    //    serial = Microsoft.VisualBasic.Interaction.InputBox("Inserte el serial para continuar", "Serial incorrecto");
                    
                     

                        //if (serial == SerialGenerado)
                        //{
                        //    Verificado = true;

                        //    // Create XmlWriterSettings.
                        //    XmlWriterSettings settings = new XmlWriterSettings();
                        //    settings.Indent = true;

                        //    // Create XmlWriter.
                        //    using (XmlWriter writer = XmlWriter.Create("verificador.xml", settings))
                        //    {
                        //        // Begin writing.
                        //        writer.WriteStartDocument();
                        //        writer.WriteStartElement("VerificadorSeriales"); // Root.

                        //        writer.WriteStartElement("serialinfo");
                        //        writer.WriteElementString("serial", serial);
                        //        writer.WriteEndElement();

                        //        // End document.
                        //        writer.WriteEndElement();
                        //        writer.WriteEndDocument();
                        //    }
                        //}
                     //
                      // }
                    //
                   
                        MessageBox.Show("Lo sentimos, no puede acceder sin haber registrado este software!", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return Verificado;
            }
            catch (Exception ex)
            {
                return false;
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
            validarUsuario();

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

                validarUsuario();
       
            }

        }

        private void validarUsuario()
        {
            if (txtUsu.Text != "")
            {
                if (txtCont.Text != "")
                {
                    if (compruebaSerial() == true)
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
                            txtUsu.Clear();
                            txtCont.Clear();
                            txtUsu.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Por favor pongase en contacto con FastCheckSoft para renovar su suscripcion");
                    }


                   
                }
                else
                {
                    msgError("Por favor ingrese su nombre de usuario");
                }
            }
            else { msgError("Por favor ingrese su contraseña"); }
        }
        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
 
        }
       

    }
}

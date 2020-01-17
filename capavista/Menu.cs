using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace capavista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMint.Visible = true;
        }

        private void btnMint_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMint.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            AbrirFormP(new Menu2());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnMenu_Click(null, e);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAltaProd_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            AbrirFormP(new AltaProd());
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModElim_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            AbrirFormP(new Consultas());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            panelSub.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMenssage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguración_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
            AbrirFormP(new Facturacion());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelSub.Visible = false;
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {
        }
        private void AbrirFormP(object formP)
        {
            if (this.panelCont.Controls.Count > 0)
                this.panelCont.Controls.RemoveAt(0);
            Form fh = formP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
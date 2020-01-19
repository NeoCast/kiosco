using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace capavista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Customizar();
        }
        private void Customizar()
        {
            panelPromocion.Visible = false;
            panelProductos.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelPromocion.Visible == true)
                panelPromocion.Visible = false;
            if (panelProductos.Visible == true)
                panelProductos.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
            hideSubMenu();
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
       
        }

        private void panelBtn_Paint (object sender, PaintEventArgs e)
        {

        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModElim_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
        
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
         
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
           
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormP(new Facturacion());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnpromocion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPromocion);
        }

        private void btnAltaProm_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormP(new nuevapromocion());
        }

        private void btnCprom_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductos);
        }

        private void btnAltaProd_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormP(new AltaProd());
        }

        private void btnConsProd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnConsProd_Click_1(object sender, EventArgs e)
        {
            AbrirFormP(new consultaProducto());
        }
    }
}
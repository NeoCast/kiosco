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
using System.Runtime.InteropServices;

namespace capavista
{
    public partial class masProm : Form
    {
        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        public masProm()
        {
            InitializeComponent();
            dataGridView1.DataSource = promocionLN.buscarDetallepromo();
        }


        private lnpromocion promocionLN = new lnpromocion();

        private void masProm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = promocionLN.buscarDetallepromo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

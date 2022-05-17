using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class FrmCarga : Form
    {
        public FrmCarga()
        {
            InitializeComponent();
            labelNombreApellido.Text = USER.Nombre + " " + USER.Apellido;
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void FrmCarga_Load(object sender, EventArgs e)
        {
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            principal.FormClosed += Logout; ;
            this.Hide();
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //es para que clikeando la barra de arriba puedas mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmCarga_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

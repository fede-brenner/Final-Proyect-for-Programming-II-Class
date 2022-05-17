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
using BLL;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        
        //Fields
        private int borderRadius = 5;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(25,25,25);
        
        public FrmPrincipal()
        {
            InitializeComponent();
            btnUser.Text = USER.Usuario;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        #region FormFunctionalty
        public void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private static bool MAXIMIZED = false;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
            }
        }

        //es para que clikeando la barra de arriba puedas mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        #region ButtonClick
        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUser());
            btnAlumnos.ForeColor = Color.DarkGray;
            btnAlumnos.IconColor = Color.DarkGray;
            btnProfesores.ForeColor = Color.DarkGray;
            btnProfesores.IconColor = Color.DarkGray;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAlumnos());
            btnProfesores.ForeColor = Color.DarkGray;
            btnProfesores.IconColor = Color.DarkGray;
            btnUser.ForeColor = Color.DarkGray;
            btnUser.IconColor = Color.DarkGray;
        }
        private void btnProfesores_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProfesores());
            btnAlumnos.ForeColor = Color.DarkGray;
            btnAlumnos.IconColor = Color.DarkGray;
            btnUser.ForeColor = Color.DarkGray;
            btnUser.IconColor = Color.DarkGray;
        }

        #endregion

        #region ButtonColoursHover

        private void btnAlumnos_MouseEnter(object sender, EventArgs e)
        {
            btnAlumnos.ForeColor = Color.White;
            btnAlumnos.IconColor = Color.White;
        }

        private void btnAlumnos_MouseLeave(object sender, EventArgs e)
        {
            if (IsFormOpen("FrmAlumnos") == false)
            {
                btnAlumnos.ForeColor = Color.DarkGray;
                btnAlumnos.IconColor = Color.DarkGray;
            }
        }

        private void btnProfesores_MouseEnter(object sender, EventArgs e)
        {
            btnProfesores.ForeColor = Color.White;
            btnProfesores.IconColor = Color.White;
        }

        private void btnProfesores_MouseLeave(object sender, EventArgs e)
        {
            if (IsFormOpen("FrmProfesores") == false)
            {
                btnProfesores.ForeColor = Color.DarkGray;
                btnProfesores.IconColor = Color.DarkGray;
            }
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.ForeColor = Color.White;
            btnUser.IconColor = Color.White;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            if (IsFormOpen("FrmUser") == false) 
            {
                btnUser.ForeColor = Color.DarkGray;
                btnUser.IconColor = Color.DarkGray;
            }
        }

        public bool IsFormOpen(string FormName)
        {
            foreach (Form form in Application.OpenForms)
                if (FormName == form.Name)
                    return true;
            return false;
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                btnAlumnos.ForeColor = Color.DarkGray;
                btnAlumnos.IconColor = Color.DarkGray;
                btnProfesores.ForeColor = Color.DarkGray;
                btnProfesores.IconColor = Color.DarkGray;
                btnUser.ForeColor = Color.DarkGray;
                btnUser.IconColor = Color.DarkGray;
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                btnAlumnos.ForeColor = Color.DarkGray;
                btnAlumnos.IconColor = Color.DarkGray;
                btnProfesores.ForeColor = Color.DarkGray;
                btnProfesores.IconColor = Color.DarkGray;
                btnUser.ForeColor = Color.DarkGray;
                btnUser.IconColor = Color.DarkGray;
            }
        }

        private void FrmPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BLL;
using ENTITY;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();

            SetPlaceHolder();
        }
        
        public void SetPlaceHolder()
        {
            rjTextBox1.SetPlaceholder();
            rjTextBox2.SetPlaceholder();
        }

        #region FormFunctionalty
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //es para que clikeando la barra de arriba puedas mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region LoginLogoutSystem
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            if (rjTextBox1.Texts != "")
            {
                if (rjTextBox2.Texts != "")
                {
                    NegocioUSER user = new NegocioUSER();
                    USER u = new USER();
                    var validLogin = user.LoginUser(u,rjTextBox1.Texts, rjTextBox2.Texts);
                    if (validLogin == true)
                    {
                        FrmCarga MenuCarga = new FrmCarga();
                        MenuCarga.Show();
                        MenuCarga.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrecta. \n   Inténtelo de nuevo.");
                        rjTextBox2.Texts = "";
                        rjTextBox1.Focus();
                    }
                }
                else msgError("Porfavor ingrese contraseña.");
            }
            else msgError("Porfavor ingrese usuario.");
        }

        private void msgError(string msg)
        {
            labelErrorMessage.Text =msg;
            labelErrorMessage.Visible = true;
            picBoxError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
            rjTextBox2.Texts = "";
            rjTextBox2.PasswordChar = true;
            rjTextBox1.Texts = "";
            labelErrorMessage.Visible = false;
            picBoxError.Visible = false;
            SetPlaceHolder();
        }

        private void picEyeClosed_Click(object sender, EventArgs e)
        {
            rjTextBox2.PasswordChar = false;
            picEyeClosed.Visible = false;
            picEyeOpen.Visible = true;
        }

        private void picEyeOpen_Click(object sender, EventArgs e)
        {
            rjTextBox2.PasswordChar = true;
            picEyeClosed.Visible = true;
            picEyeOpen.Visible = false;
        }

        #endregion

    }
}

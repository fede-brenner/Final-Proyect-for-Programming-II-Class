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
using System.Globalization;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class FrmUser : Form
    {
        
        public FrmUser()
        {
            InitializeComponent();
            NegocioUSER negocio = new NegocioUSER();
            negocio.MostrarUser(dataGridView1, Tabla);
            CustomizeDesign();
        }
        public string Tabla = "Users";
        private void CustomizeDesign()
        {
            labelUsuario.Text = USER.Usuario;
            labelNombre.Text = USER.Nombre;
            labelApellido.Text = USER.Apellido;
            labelMailPersonal.Text = USER.EmailPersonal;
            labelMailInstitucional.Text = USER.EmailInstitucional;
            labelContraseña.Text = USER.Contraseña;
            if(USER.Posicion == "Administrador")
            {
                btnAddUser.Visible = true;
                dataGridView1.Visible = true;
                labelInfoUsers.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
            }
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 40;
            column = dataGridView1.Columns[1];
            column.Width = 60;
            column = dataGridView1.Columns[2];
            column.Width = 60;
            column = dataGridView1.Columns[3];
            column.Width = 80;
            column = dataGridView1.Columns[4];
            column.Width = 70;
            column = dataGridView1.Columns[5];
            column.Width = 80;
            column = dataGridView1.Columns[6];
            column.Width = 80;

            SetPlaceHolder();
        }

        public void SetPlaceHolder()
        {
            rjTextBox1.SetPlaceholder();
            rjTextBox2.SetPlaceholder();
            rjTextBox3.SetPlaceholder();
            rjTextBox4.SetPlaceholder();
            rjTextBox5.SetPlaceholder();
            rjTextBox6.SetPlaceholder();
            rjTextBox7.SetPlaceholder();
            rjTextBox8.SetPlaceholder();
        }

        private void SetNormal()
        {
            labelErrorMessage.Visible = false;
            picBoxError.Visible = false;
            labelSuccesfulMessage.Visible = false;
            picBoxSuccesful.Visible = false;
            rjTextBox1.BorderColor = Color.FromArgb(35, 35, 35);
            rjTextBox2.BorderColor = Color.FromArgb(35, 35, 35);
            rjTextBox3.BorderColor = Color.FromArgb(35, 35, 35);
            rjTextBox4.BorderColor = Color.FromArgb(35, 35, 35);
            rjTextBox5.BorderColor = Color.FromArgb(35, 35, 35);
            rjTextBox6.BorderColor = Color.FromArgb(35, 35, 35);
            rjTextBox7.BorderColor = Color.FromArgb(35, 35, 35);
            rjTextBox8.BorderColor = Color.FromArgb(35, 35, 35);

            rjTextBox1.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox2.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox3.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox4.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox5.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox6.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox7.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox8.BorderFocusColor = Color.FromArgb(35, 35, 35);

        }
        private void SetEmpty()
        {
            rjTextBox1.Texts = "";
            rjTextBox2.Texts = "";
            rjTextBox3.Texts = "";
            rjTextBox4.Texts = "";
            rjTextBox5.Texts = "";
            rjTextBox6.Texts = "";
            rjTextBox7.Texts = "";
            rjTextBox8.Texts = "";
        }
        private void msgSuccesful(string msg)
        {
            labelSuccesfulMessage.Text = msg;
            labelSuccesfulMessage.Visible = true;
            picBoxSuccesful.Visible = true;
        }

        private void msgError(string msg)
        {
            labelErrorMessage.Text = msg;
            labelErrorMessage.Visible = true;
            picBoxError.Visible = true;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            panelAbmUser.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SetNormal();
            Regex regex = new Regex("^[a-zA-Z]+$");
            Regex regexNum = new Regex("^[0-9]+$");
            if (rjTextBox1.Texts != "")
            {
                if (rjTextBox5.Texts != "")
                {
                    if (rjTextBox2.Texts != "")
                    {
                        bool hasOnlyLastName = regex.IsMatch(rjTextBox2.Texts);
                        Regex regexSpace = new Regex(@"\s+");
                        bool hasSpaces = regexSpace.IsMatch(rjTextBox2.Texts);
                        if (hasOnlyLastName || hasSpaces)
                        {
                            if (rjTextBox3.Texts != "")
                            {
                                bool hasOnlyName = regex.IsMatch(rjTextBox3.Texts);
                                hasSpaces = regexSpace.IsMatch(rjTextBox3.Texts);
                                if (hasOnlyName || hasSpaces)
                                {
                                    if (rjTextBox7.Texts != "")
                                    {
                                        if (rjTextBox8.Texts != "")
                                        {
                                            bool hasOnlyTelNum = regexNum.IsMatch(rjTextBox8.Texts);
                                            if (hasOnlyTelNum)
                                            {
                                                if (rjTextBox4.Texts != "")
                                                {
                                                    if (IsValidEmail(rjTextBox4.Texts))
                                                    {
                                                        if (rjTextBox6.Texts != "")
                                                        {
                                                            if (IsValidEmail(rjTextBox6.Texts))
                                                            {
                                                                NegocioUSER negocioUSER = new NegocioUSER();

                                                                USER.Usuario = rjTextBox1.Texts;
                                                                USER.Apellido = rjTextBox2.Texts;
                                                                USER.Nombre = rjTextBox3.Texts;
                                                                USER.Posicion = rjTextBox7.Texts;
                                                                USER.Telefono = Convert.ToInt32(rjTextBox8.Texts);
                                                                USER.EmailPersonal = rjTextBox4.Texts;
                                                                USER.Contraseña = rjTextBox5.Texts;
                                                                USER.EmailInstitucional = rjTextBox6.Texts;
                                                                labelErrorMessage.Visible = false;
                                                                picBoxError.Visible = false;
                                                                if (negocioUSER.Agregar())
                                                                {
                                                                    negocioUSER.MostrarUser(dataGridView1, Tabla);
                                                                    msgSuccesful("Se ha agregado el Usuario satisfactoriamente");
                                                                    SetEmpty();
                                                                    SetPlaceHolder();
                                                                }
                                                                else
                                                                {
                                                                    msgError("El Usuario ya existe");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                rjTextBox6.BorderColor = Color.Brown;
                                                                rjTextBox6.BorderFocusColor = Color.Brown;
                                                                msgError("Email Institucional incorrecto");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            rjTextBox6.BorderColor = Color.Brown;
                                                            rjTextBox6.BorderFocusColor = Color.Brown;
                                                            msgError("Debe ingresar un Email Institucional");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        rjTextBox4.BorderColor = Color.Brown;
                                                        rjTextBox4.BorderFocusColor = Color.Brown;
                                                        msgError("Email Personal incorrecto");
                                                    }

                                                }
                                                else
                                                {
                                                    rjTextBox4.BorderColor = Color.Brown;
                                                    rjTextBox4.BorderFocusColor = Color.Brown;
                                                    msgError("Debe ingresar un Email Personal");
                                                }
                                            }
                                            else
                                            {
                                                rjTextBox8.BorderColor = Color.Brown;
                                                rjTextBox8.BorderFocusColor = Color.Brown;
                                                msgError("Porfavor no ingrese letras, espacios, ni ningun tipo de simbolo");
                                            }
                                        }
                                        else
                                        {
                                            rjTextBox8.BorderColor = Color.Brown;
                                            rjTextBox8.BorderFocusColor = Color.Brown;
                                            msgError("Debe ingresar un Telefono");
                                        }
                                    }
                                    else
                                    {
                                        rjTextBox7.BorderColor = Color.Brown;
                                        rjTextBox7.BorderFocusColor = Color.Brown;
                                        msgError("Debe ingresar una Posicion");
                                    }
                                }
                                else
                                {
                                    rjTextBox3.BorderColor = Color.Brown;
                                    rjTextBox3.BorderFocusColor = Color.Brown;
                                    msgError("Porfavor no ingrese números, espacios, ni ningun tipo de simbolo");
                                }
                            }
                            else
                            {
                                rjTextBox3.BorderColor = Color.Brown;
                                rjTextBox3.BorderFocusColor = Color.Brown;
                                msgError("Porfavor ingrese un Nombre");
                            }
                        }
                        else
                        {
                            rjTextBox2.BorderColor = Color.Brown;
                            rjTextBox2.BorderFocusColor = Color.Brown;
                            msgError("Porfavor no ingrese números, espacios, ni ningun tipo de simbolo");
                        }
                    }
                    else
                    {
                        rjTextBox2.BorderColor = Color.Brown;
                        rjTextBox2.BorderFocusColor = Color.Brown;
                        msgError("Porfavor ingrese un Apellido");
                    }
                }
                else
                {
                    rjTextBox5.BorderColor = Color.Brown;
                    rjTextBox5.BorderFocusColor = Color.Brown;
                    msgError("Debe ingresar una Contraseña");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                rjTextBox1.BorderFocusColor = Color.Brown;
                msgError("Debe ingresar un Usuario");
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            SetNormal();
            if (rjTextBox1.Texts != "")
            {
                NegocioUSER negocioUSER = new NegocioUSER();
                USER.Usuario = rjTextBox1.Texts;
                labelErrorMessage.Visible = false;
                picBoxError.Visible = false;
                if (negocioUSER.Borrar())
                {
                    negocioUSER.MostrarUser(dataGridView1, Tabla);
                    msgSuccesful("Se ha borrado el Usuario satisfactoriamente");
                    SetEmpty();
                    SetPlaceHolder();
                }
                else
                {
                    msgError("El Usuario no existe");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                msgError("Debe ingresar un Usuario");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SetNormal();
            Regex regex = new Regex("^[a-zA-Z]+$");
            Regex regexNum = new Regex("^[0-9]+$");
            if (rjTextBox1.Texts != "")
            {
                if (rjTextBox5.Texts != "")
                {
                    if (rjTextBox2.Texts != "")
                    {
                        bool hasOnlyLastName = regex.IsMatch(rjTextBox2.Texts);
                        Regex regexSpace = new Regex(@"\s+");
                        bool hasSpaces = regexSpace.IsMatch(rjTextBox2.Texts);
                        if (hasOnlyLastName || hasSpaces)
                        {
                            if (rjTextBox3.Texts != "")
                            {
                                bool hasOnlyName = regex.IsMatch(rjTextBox3.Texts);
                                hasSpaces = regexSpace.IsMatch(rjTextBox3.Texts);
                                if (hasOnlyName || hasSpaces)
                                {
                                    if (rjTextBox7.Texts != "")
                                    {
                                        if (rjTextBox8.Texts != "")
                                        {
                                            bool hasOnlyTelNum = regexNum.IsMatch(rjTextBox8.Texts);
                                            if (hasOnlyTelNum)
                                            {
                                                if (rjTextBox4.Texts != "")
                                                {
                                                    if (IsValidEmail(rjTextBox4.Texts))
                                                    {
                                                        if (rjTextBox6.Texts != "")
                                                        {
                                                            if (IsValidEmail(rjTextBox6.Texts))
                                                            {
                                                                NegocioUSER negocioUSER = new NegocioUSER();
                                                                USER.Usuario = rjTextBox1.Texts;
                                                                USER.Apellido = rjTextBox2.Texts;
                                                                USER.Nombre = rjTextBox3.Texts;
                                                                USER.Posicion = rjTextBox7.Texts;
                                                                USER.Telefono = Convert.ToInt32(rjTextBox8.Texts);
                                                                USER.EmailPersonal = rjTextBox4.Texts;
                                                                USER.Contraseña = rjTextBox5.Texts;
                                                                USER.EmailInstitucional = rjTextBox6.Texts;
                                                                labelErrorMessage.Visible = false;
                                                                picBoxError.Visible = false;
                                                                if (negocioUSER.Modificar())
                                                                {
                                                                    msgSuccesful("Se ha modificado el Usuario satisfactoriamente");
                                                                    negocioUSER.MostrarUser(dataGridView1, Tabla);
                                                                    SetEmpty();
                                                                    SetPlaceHolder();
                                                                }
                                                                else
                                                                {
                                                                    msgError("No existe el Usuario que desea Modificar");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                rjTextBox6.BorderColor = Color.Brown;
                                                                rjTextBox6.BorderFocusColor = Color.Brown;
                                                                msgError("Email Institucional incorrecto");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            rjTextBox6.BorderColor = Color.Brown;
                                                            rjTextBox6.BorderFocusColor = Color.Brown;
                                                            msgError("Debe ingresar un Email Institucional");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        rjTextBox4.BorderColor = Color.Brown;
                                                        rjTextBox4.BorderFocusColor = Color.Brown;
                                                        msgError("Email Personal incorrecto");
                                                    }

                                                }
                                                else
                                                {
                                                    rjTextBox4.BorderColor = Color.Brown;
                                                    rjTextBox4.BorderFocusColor = Color.Brown;
                                                    msgError("Debe ingresar un Email Personal");
                                                }
                                            }
                                            else
                                            {
                                                rjTextBox8.BorderColor = Color.Brown;
                                                rjTextBox8.BorderFocusColor = Color.Brown;
                                                msgError("Porfavor no ingrese letras, espacios, ni ningun tipo de simbolo");
                                            }
                                        }
                                        else
                                        {
                                            rjTextBox8.BorderColor = Color.Brown;
                                            rjTextBox8.BorderFocusColor = Color.Brown;
                                            msgError("Debe ingresar un Telefono");
                                        }
                                    }
                                    else
                                    {
                                        rjTextBox7.BorderColor = Color.Brown;
                                        rjTextBox7.BorderFocusColor = Color.Brown;
                                        msgError("Debe ingresar una Posicion");
                                    }
                                }
                                else
                                {
                                    rjTextBox3.BorderColor = Color.Brown;
                                    rjTextBox3.BorderFocusColor = Color.Brown;
                                    msgError("Porfavor no ingrese números, espacios, ni ningun tipo de simbolo");
                                }
                            }
                            else
                            {
                                rjTextBox3.BorderColor = Color.Brown;
                                rjTextBox3.BorderFocusColor = Color.Brown;
                                msgError("Porfavor ingrese un Nombre");
                            }
                        }
                        else
                        {
                            rjTextBox2.BorderColor = Color.Brown;
                            rjTextBox2.BorderFocusColor = Color.Brown;
                            msgError("Porfavor no ingrese números, espacios, ni ningun tipo de simbolo");
                        }
                    }
                    else
                    {
                        rjTextBox2.BorderColor = Color.Brown;
                        rjTextBox2.BorderFocusColor = Color.Brown;
                        msgError("Porfavor ingrese un Apellido");
                    }
                }
                else
                {
                    rjTextBox5.BorderColor = Color.Brown;
                    rjTextBox5.BorderFocusColor = Color.Brown;
                    msgError("Debe ingresar una Contraseña");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                rjTextBox1.BorderFocusColor = Color.Brown;
                msgError("Debe ingresar un Usuario");
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SetNormal();
            if (rjTextBox1.Texts != "")
            {
                NegocioUSER negocioUSER = new NegocioUSER();
                if (negocioUSER.Buscar(rjTextBox1.Texts))
                {
                    rjTextBox1.Texts = USER.Usuario;
                    rjTextBox2.Texts = USER.Apellido;
                    rjTextBox3.Texts = USER.Nombre;
                    rjTextBox7.Texts = USER.Posicion;
                    rjTextBox8.Texts = USER.Telefono.ToString();
                    rjTextBox4.Texts = USER.EmailPersonal;
                    rjTextBox5.Texts = USER.Contraseña;
                    rjTextBox6.Texts = USER.EmailInstitucional;
                }
                else
                {
                    msgError("No existe el Usuario que desea Buscar");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                msgError("Debe ingresar un Usuario");
            }
            
        }
    }
}

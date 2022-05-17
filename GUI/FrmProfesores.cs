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
    public partial class FrmProfesores : Form
    {
        public string Tabla = "profesor";
        public FrmProfesores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            CustomizeDesign();
        }

        public void CustomizeDesign()
        {
            NegocioALUMNO negocio = new NegocioALUMNO();
            negocio.MostrarTabla(dataGridView1, Tabla);

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 80;
            column = dataGridView1.Columns[1];
            column.Width = 120;
            column = dataGridView1.Columns[2];
            column.Width = 120;
            column = dataGridView1.Columns[3];
            column.Width = 90;

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
        }

        private void SetEmpty()
        {
            rjTextBox1.Texts = "";
            rjTextBox2.Texts = "";
            rjTextBox3.Texts = "";
            rjTextBox4.Texts = "";
            rjTextBox5.Texts = "";
            rjTextBox6.Texts = "";
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

            rjTextBox1.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox2.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox3.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox4.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox5.BorderFocusColor = Color.FromArgb(35, 35, 35);
            rjTextBox6.BorderFocusColor = Color.FromArgb(35, 35, 35);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SetNormal();
            if (rjTextBox1.Texts != "")
            {
                Regex regexNum = new Regex("^[0-9]+$");
                bool hasOnlyDNINum = regexNum.IsMatch(rjTextBox1.Texts);
                if (hasOnlyDNINum)
                {
                    if (rjTextBox2.Texts != "")
                    {
                        Regex regex = new Regex("^[a-zA-Z]+$");
                        bool hasOnlyAlphaName = regex.IsMatch(rjTextBox2.Texts);
                        Regex regexSpace = new Regex(@"\s+");
                        bool hasSpaces = regexSpace.IsMatch(rjTextBox2.Texts);
                        if (hasOnlyAlphaName || hasSpaces)
                        {
                            if (rjTextBox3.Texts != "")
                            {
                                bool hasOnlyAlphaLastName = regex.IsMatch(rjTextBox3.Texts);
                                hasSpaces = regexSpace.IsMatch(rjTextBox3.Texts);
                                if (hasOnlyAlphaLastName || hasSpaces)
                                {
                                    if (rjTextBox6.Texts != "")
                                    {
                                        bool hasOnlyTelNum = regexNum.IsMatch(rjTextBox6.Texts);
                                        if (hasOnlyTelNum)
                                        {
                                            if (rjTextBox4.Texts != "")
                                            {
                                                if (IsValidEmail(rjTextBox4.Texts))
                                                {
                                                    if (rjTextBox5.Texts != "")
                                                    {
                                                        if (IsValidEmail(rjTextBox5.Texts))
                                                        {
                                                            NegocioPROFESOR negocio = new NegocioPROFESOR();
                                                            PERSONA p = new PERSONA();
                                                            p.DNI = Convert.ToInt32(rjTextBox1.Texts);
                                                            p.APELLIDO = rjTextBox2.Texts;
                                                            p.NOMBRE = rjTextBox3.Texts;
                                                            p.TELEFONO = Convert.ToInt32(rjTextBox6.Texts);
                                                            p.EMAILPERSONAL = rjTextBox4.Texts;
                                                            p.EMAILINSTITUCIONAL = rjTextBox5.Texts;

                                                            labelErrorMessage.Visible = false;
                                                            picBoxError.Visible = false;
                                                            if (negocio.Agregar(p))
                                                            {
                                                                msgSuccesful("Se ha agregado el profesor satisfactoriamente");
                                                                negocio.MostrarTabla(dataGridView1, Tabla);
                                                                SetEmpty();
                                                                SetPlaceHolder();
                                                            }
                                                            else
                                                            {
                                                                msgError("Ya existe el Profesor");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            rjTextBox5.BorderColor = Color.Brown;
                                                            rjTextBox5.BorderFocusColor = Color.Brown;
                                                            msgError("Email Institucional incorrecto");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        rjTextBox5.BorderColor = Color.Brown;
                                                        rjTextBox5.BorderFocusColor = Color.Brown;
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
                                            rjTextBox6.BorderColor = Color.Brown;
                                            rjTextBox6.BorderFocusColor = Color.Brown;
                                            msgError("Porfavor no ingrese letras, espacios, ni ningun tipo de simbolo");
                                        }
                                    }
                                    else
                                    {
                                        rjTextBox6.BorderColor = Color.Brown;
                                        rjTextBox6.BorderFocusColor = Color.Brown;
                                        msgError("Debe ingresar un Telefono");
                                    }
                                }
                                else
                                {
                                    rjTextBox3.BorderColor = Color.Brown;
                                    rjTextBox3.BorderFocusColor = Color.Brown;
                                    msgError("Porfavor no ingrese números, ni ningun tipo de simbolo");
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
                            msgError("Porfavor no ingrese números, ni ningun tipo de simbolo");
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
                    rjTextBox1.BorderColor = Color.Brown;
                    rjTextBox1.BorderFocusColor = Color.Brown;
                    msgError("Porfavor no ingrese letras, espacios, ni ningun tipo de simbolo");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                rjTextBox1.BorderFocusColor = Color.Brown;
                msgError("Debe ingresar un DNI");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            SetNormal();
            if (rjTextBox1.Texts != "")
            {
                NegocioPROFESOR negocio = new NegocioPROFESOR();
                PERSONA p = new PERSONA();
                p.DNI = Convert.ToInt32(rjTextBox1.Texts);
                labelErrorMessage.Visible = false;
                picBoxError.Visible = false;
                if (negocio.Borrar(p))
                {
                    msgSuccesful("Se ha borrado el profesor satisfactoriamente");
                    negocio.MostrarTabla(dataGridView1, Tabla);
                    SetEmpty();
                    SetPlaceHolder();
                }
                else
                {
                    msgError("No existe el Profesor que se deasea borrar");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                msgError("Debe ingresar un DNI");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SetNormal();
            if (rjTextBox1.Texts != "")
            {
                Regex regexNum = new Regex("^[0-9]+$");
                bool hasOnlyDNINum = regexNum.IsMatch(rjTextBox1.Texts);
                if (hasOnlyDNINum)
                {
                    if (rjTextBox2.Texts != "")
                    {
                        Regex regex = new Regex("^[a-zA-Z]+$");
                        bool hasOnlyAlphaName = regex.IsMatch(rjTextBox2.Texts);
                        Regex regexSpace = new Regex(@"\s+");
                        bool hasSpaces = regexSpace.IsMatch(rjTextBox2.Texts);
                        if (hasOnlyAlphaName || hasSpaces)
                        {
                            if (rjTextBox3.Texts != "")
                            {
                                bool hasOnlyAlphaLastName = regex.IsMatch(rjTextBox3.Texts);
                                hasSpaces = regexSpace.IsMatch(rjTextBox3.Texts);
                                if (hasOnlyAlphaLastName || hasSpaces)
                                {
                                    if (rjTextBox6.Texts != "")
                                    {
                                        bool hasOnlyTelNum = regexNum.IsMatch(rjTextBox6.Texts);
                                        if (hasOnlyTelNum)
                                        {
                                            if (rjTextBox4.Texts != "")
                                            {
                                                if (IsValidEmail(rjTextBox4.Texts))
                                                {
                                                    if (rjTextBox5.Texts != "")
                                                    {
                                                        if (IsValidEmail(rjTextBox5.Texts))
                                                        {
                                                            NegocioPROFESOR negocio = new NegocioPROFESOR();
                                                            PERSONA p = new PERSONA();
                                                            p.DNI = Convert.ToInt32(rjTextBox1.Texts);
                                                            p.APELLIDO = rjTextBox2.Texts;
                                                            p.NOMBRE = rjTextBox3.Texts;
                                                            p.TELEFONO = Convert.ToInt32(rjTextBox6.Texts);
                                                            p.EMAILPERSONAL = rjTextBox4.Texts;
                                                            p.EMAILINSTITUCIONAL = rjTextBox5.Texts;
                                                            labelErrorMessage.Visible = false;
                                                            picBoxError.Visible = false;
                                                            if (negocio.Modificar(p))
                                                            {
                                                                msgSuccesful("Se ha modificado el profesor satisfactoriamente");
                                                                negocio.MostrarTabla(dataGridView1, Tabla);
                                                                SetEmpty();
                                                                SetPlaceHolder();
                                                            }
                                                            else
                                                            {
                                                                msgError("No existe el Profesor que se desea Modificar");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            rjTextBox5.BorderColor = Color.Brown;
                                                            rjTextBox5.BorderFocusColor = Color.Brown;
                                                            msgError("Email Institucional incorrecto");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        rjTextBox5.BorderColor = Color.Brown;
                                                        rjTextBox5.BorderFocusColor = Color.Brown;
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
                                            rjTextBox6.BorderColor = Color.Brown;
                                            rjTextBox6.BorderFocusColor = Color.Brown;
                                            msgError("Porfavor no ingrese letras, ni ningun tipo de simbolo");
                                        }
                                    }
                                    else
                                    {
                                        rjTextBox6.BorderColor = Color.Brown;
                                        rjTextBox6.BorderFocusColor = Color.Brown;
                                        msgError("Debe ingresar un Telefono");
                                    }
                                }
                                else
                                {
                                    rjTextBox3.BorderColor = Color.Brown;
                                    rjTextBox3.BorderFocusColor = Color.Brown;
                                    msgError("Porfavor no ingrese números, ni ningun tipo de simbolo");
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
                            msgError("Porfavor no ingrese números, ni ningun tipo de simbolo");
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
                    rjTextBox1.BorderColor = Color.Brown;
                    rjTextBox1.BorderFocusColor = Color.Brown;
                    msgError("Porfavor no ingrese letras, ni ningun tipo de simbolo");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                rjTextBox1.BorderFocusColor = Color.Brown;
                msgError("Debe ingresar un DNI");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SetNormal();
            if (rjTextBox1.Texts != "")
            {
                NegocioPROFESOR negocio = new NegocioPROFESOR();
                PERSONA p = new PERSONA();
                if (negocio.Buscar(p, Convert.ToInt32(rjTextBox1.Texts)))
                {
                    rjTextBox2.Texts = p.APELLIDO;
                    rjTextBox3.Texts = p.NOMBRE;
                    rjTextBox6.Texts = p.TELEFONO.ToString();
                    rjTextBox4.Texts = p.EMAILPERSONAL;
                    rjTextBox5.Texts = p.EMAILINSTITUCIONAL;
                }
                else
                {
                    msgError("No existe el Alumno que se desea buscar");
                }
            }
            else
            {
                rjTextBox1.BorderColor = Color.Brown;
                msgError("Debe ingresar un DNI");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void rjTextBox4__TextChanged(object sender, EventArgs e)
        {
            rjTextBox4.BorderColor = Color.FromArgb(35,35,35);
        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {
            rjTextBox5.BorderColor = Color.FromArgb(35, 35, 35);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos csv |*.csv";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            NegocioALUMNO negocio = new NegocioALUMNO();
            negocio.ExportarCSV(saveFileDialog1.FileName, "alumno");
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos (txt,csv)|*.txt;*.csv*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;

            NegocioALUMNO negocio = new NegocioALUMNO();
            negocio.ImportarArchivo(archivo);
        }
    }
}

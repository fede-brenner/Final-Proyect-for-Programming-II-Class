using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTITY;
using System.IO;
using System.Data;
using System.Windows.Forms;


namespace DAL
{
    public class DatosALUMNO : ConexionSql
    {
        SqlConnection Cnx;
        SqlCommand Cmd;

        public DatosALUMNO()
        {
            Cnx = GetConnection();
            Cnx.Open();
        }

        public void ComandoSql(string comando)
        {

            Cmd = new SqlCommand(comando, Cnx);
            Cmd.ExecuteNonQuery();

        }

        public bool Agregar(PERSONA p)
        {
            string strSql = "";
            try
            {
                strSql = "INSERT INTO alumno(DNI,Apellido,Nombre,Telefono,EmailPersonal,EmailInstitucional) VALUES(" + p.DNI + ",'" + p.APELLIDO + "','" + p.NOMBRE + "','" + p.TELEFONO + "','" + p.EMAILPERSONAL + "','" + p.EMAILINSTITUCIONAL + "');";
                Cmd = new SqlCommand(strSql, Cnx);
                Cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Borrar(PERSONA p)
        {
            string strSql = "";
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from alumno where DNI='" + p.DNI + "';", Cnx))
            {
                int userCount = (int)sqlCommand.ExecuteScalar();
                if (userCount == 0)
                {
                    return false;
                }
                strSql = "DELETE FROM alumno WHERE DNI=" + p.DNI + ";";
                Cmd = new SqlCommand(strSql, Cnx);
                Cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool Modificar(PERSONA p)
        {
            string strSql = "";
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from alumno where DNI='" + p.DNI + "';", Cnx))
            {
                int userCount = (int)sqlCommand.ExecuteScalar();
                if (userCount == 0)
                {
                    return false;
                }
                strSql = "UPDATE alumno SET Apellido='" + p.APELLIDO + "', Nombre='" + p.NOMBRE + "', Telefono='" + p.TELEFONO + "', EmailPersonal='" + p.EMAILPERSONAL + "', EmailInstitucional='" + p.EMAILINSTITUCIONAL + "' WHERE DNI='" + p.DNI + "';";
                Cmd = new SqlCommand(strSql, Cnx);
                Cmd.ExecuteNonQuery();
            }
            return true;
        }

        public bool BuscarPersona(PERSONA p, int DNI)
        {
            SqlDataReader Dtr;

            Cmd = new SqlCommand("SELECT * FROM alumno WHERE DNI=" + DNI, Cnx);
            Dtr = Cmd.ExecuteReader();
            if (Dtr.Read())
            {
                p.DNI = Convert.ToInt32(Dtr[0]);
                p.APELLIDO = Dtr[1].ToString();
                p.NOMBRE = Dtr[2].ToString();
                p.TELEFONO = Convert.ToInt32(Dtr[3]);
                p.EMAILPERSONAL = Dtr[4].ToString();
                p.EMAILINSTITUCIONAL = Dtr[5].ToString();
                return true;
            }
            else
                return false;

        }

        public DataTable MostrarTabla(string Tabla)
        {

            DataTable Tbl = new DataTable();
            SqlDataAdapter Ada = new SqlDataAdapter("SELECT * FROM " + Tabla, Cnx);
            Ada.Fill(Tbl);
            return Tbl;

        }

        public void ExportarCsv(string ruta, string tabla)
        {
            try
            {
                StreamWriter archivo = new StreamWriter(ruta);
                Cmd = new SqlCommand("SELECT * FROM " + tabla, Cnx);
                SqlDataReader Dtr = Cmd.ExecuteReader();
                string encabezado = "DNI;Apellido;Nombre;Telefono;EmailPersonal;EmailInstitucional";
                archivo.WriteLine(encabezado);
                while (Dtr.Read())
                {
                    string linea = Dtr[0].ToString() + ";" + Dtr[1].ToString() + ";" + Dtr[2].ToString() + ";" + Dtr[3].ToString() + ";" + Dtr[4].ToString() + ";" + Dtr[5].ToString();
                    archivo.WriteLine(linea);
                }
                archivo.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Debe seleccionar una ruta para guardar el archivo");
            }
        }

        public void ImportarPlano(string nombrearchivo)
        {
            try
            {
                StreamReader archivo = new StreamReader(nombrearchivo, Encoding.Default);
                string encabezado = archivo.ReadLine();
                while (archivo.Peek() > 1)
                {
                    string[] registro;
                    registro = archivo.ReadLine().Split(';');

                    Cmd = new SqlCommand("INSERT INTO alumno (DNI,Apellido,Nombre,Telefono,EmailPersonal,EmailInstitucional) VALUES(" + registro[0] + ", '" + registro[1] + "','" + registro[2] + "', '" + registro[3] + "','" + registro[4] + "','" + registro[5] + "')", Cnx);
                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado un archivo valido");
            }
            MessageBox.Show("Los datos fueron cargados exitosamente");
            Cnx.Close();
        }

    }
}

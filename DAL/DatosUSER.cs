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
    public class DatosUSER : ConexionSql
    {
        SqlConnection Cnx;
        SqlCommand Cmd;
        public DatosUSER()
        {
            Cnx = GetConnection();
            Cnx.Open();
        }
        public bool Login(USER u,string user, string pass)
        {
            using (Cmd = new SqlCommand())
            {
                Cmd.Connection = Cnx;
                Cmd.CommandText = "select*from Users where Usuario=@user and Contraseña=@pass";
                Cmd.Parameters.AddWithValue("@user", user);
                Cmd.Parameters.AddWithValue("@pass", pass);
                Cmd.CommandType = CommandType.Text;
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        USER.IdUser = reader.GetInt32(0);
                        USER.Usuario = reader.GetString(1);
                        USER.Contraseña = reader.GetString(2);
                        USER.Apellido = reader.GetString(3);
                        USER.Nombre = reader.GetString(4);
                        USER.Posicion = reader.GetString(5);
                        USER.Telefono = reader.GetInt32(6);
                        USER.EmailPersonal = reader.GetString(7);
                        USER.EmailInstitucional = reader.GetString(8);
                    }
                    return true;
                }
                else
                    return false;
            }
        }
        public DataTable MostrarUser(string Tabla)
        {
            DataTable Tbl = new DataTable();
            SqlDataAdapter Ada = new SqlDataAdapter("SELECT * FROM " + Tabla , Cnx);
            Ada.Fill(Tbl);
            return Tbl;

        }
        public bool Agregar()
        {
            string strSql = "";
            try
            {
                strSql = "INSERT INTO Users (Usuario,Contraseña,Apellido,Nombre,Posicion,Telefono,EmailPersonal,EmailInstitucional) VALUES('" + USER.Usuario + "','" + USER.Contraseña + "','" + USER.Apellido + "','" + USER.Nombre + "','" + USER.Posicion + "','" + USER.Telefono + "','" + USER.EmailPersonal + "','" + USER.EmailInstitucional + "');";
                Cmd = new SqlCommand(strSql, Cnx);
                Cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Borrar()
        {
            string strSql = "";
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from Users where Usuario='" + USER.Usuario + "';", Cnx))
            {
                int userCount = (int)sqlCommand.ExecuteScalar();
                if (userCount == 0)
                {
                    return false;
                }
                strSql = "DELETE FROM Users WHERE Usuario='" + USER.Usuario + "';";
                Cmd = new SqlCommand(strSql, Cnx);
                Cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool Modificar()
        {
            string strSql = "";
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from Users where Usuario='" + USER.Usuario + "';", Cnx))
            {
                int userCount = (int)sqlCommand.ExecuteScalar();
                if (userCount == 0)
                {
                    return false;
                }
                strSql = "UPDATE Users SET Apellido='" + USER.Apellido + "', Nombre='" + USER.Nombre + "', Contraseña='" + USER.Contraseña + "', Posicion='" + USER.Posicion + "', Telefono='" + USER.Telefono + "', EmailPersonal='" + USER.EmailPersonal + "', EmailInstitucional='" + USER.EmailInstitucional + "' WHERE Usuario='" + USER.Usuario + "';";
                Cmd = new SqlCommand(strSql, Cnx);
                Cmd.ExecuteNonQuery();
            }
            return true;
        }

        public bool BuscarPersona(string User)
        {
            SqlDataReader reader;

            Cmd = new SqlCommand("SELECT * FROM Users WHERE Usuario='" + User + "'", Cnx);
            reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                USER.IdUser = reader.GetInt32(0);
                USER.Usuario = reader.GetString(1);
                USER.Contraseña = reader.GetString(2);
                USER.Apellido = reader.GetString(3);
                USER.Nombre = reader.GetString(4);
                USER.Posicion = reader.GetString(5);
                USER.Telefono = reader.GetInt32(6);
                USER.EmailPersonal = reader.GetString(7);
                USER.EmailInstitucional = reader.GetString(8);
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;
using System.Windows.Forms;

namespace BLL
{
    public class NegocioUSER
    {
        DatosUSER datosUser = new DatosUSER();
        public bool LoginUser(USER u,string user, string pass)
        {
            return datosUser.Login(u,user, pass);
        }

        public bool Agregar()
        {
            return datosUser.Agregar();
        }

        public bool Borrar()
        {
            return datosUser.Borrar();
        }

        public bool Modificar()
        {
            return datosUser.Modificar();
        }

        public bool Buscar(string User)
        {
            return datosUser.BuscarPersona(User);
        }

        public void MostrarUser(DataGridView Dtg, string tabla)
        {

            Dtg.DataSource = datosUser.MostrarUser(tabla);

        }
    }
}

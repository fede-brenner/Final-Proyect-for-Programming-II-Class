using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class NegocioPROFESOR
    {
        DatosPROFESOR datos;

        public NegocioPROFESOR()
        {
            datos = new DatosPROFESOR();
        }

        public bool Agregar(PERSONA p)
        {
            return datos.Agregar(p);
        }

        public bool Borrar(PERSONA p)
        {
            return datos.Borrar(p);
        }

        public bool Modificar(PERSONA p)
        {
            return datos.Modificar(p);
        }

        public bool Buscar(PERSONA p, int dni)
        {
            return datos.BuscarPersona(p,dni);
        }

        public void ExportarCSV(string ruta, string tabla)
        {

            datos.ExportarCsv(ruta, tabla);

        }
        public void ImportarArchivo(string archivo)
        {

            datos.ImportarPlano(archivo);
        }
        public void MostrarTabla(DataGridView Dtg, string tabla)
        {

            Dtg.DataSource = datos.MostrarTabla(tabla);

        }
    }
}

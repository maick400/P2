using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Proyecto.Cooperativa.Clases
{
    /*************atributo******************/
    class Socios
    {
       public int id {get; set;}
        Cooperativa cooperativa { get; set; }
        string nombre { get; set; }
        string apellido { get; set; }
        int cedula { get; set; }
        string email { get; set; }
        string direccion { get; set; }
        string fechainicio { get; set; }

        /*funciones*/
        public DataTable Listarsocios()
        {
            return new DataTable();
        }

        /****metodos****/
        public void Agregarsocios()
        {

        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }
    }

   



}

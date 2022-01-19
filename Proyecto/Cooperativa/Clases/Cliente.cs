using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Cooperativa.Clases
{
    class Cliente
    {
        /*atributos*/
        Cooperativa idcooperativa { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int cedula { get; set; }
        public string direccion { get; set; }
        public string cuidad { get; set; }
        public int telefono1 { get; set; }
        public int telefono2 { get; set; }
        public string email { get; set; }
        public string tiposangre { get; set; }

        /*funciones*/
        public DataTable Listarsocios()
        {
            return new DataTable();
        }
        /*metodos*/
        public void Registrarcliente()
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

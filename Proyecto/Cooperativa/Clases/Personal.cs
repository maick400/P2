using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Cooperativa.Clases
{
    internal class Personal
    {
        //variables
        int id;
        Cooperativa Cooperativa;
        string nombres;
        string apellidos;
        string cedula;
        string ciudad;
        string direccion;
        string telefono1;
        string telefono2;
        //---------

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono1 { get => telefono1; set => telefono1 = value; }
        public string Telefono2 { get => telefono2; set => telefono2 = value; }
        internal Cooperativa Cooperativa1 { get => Cooperativa; set => Cooperativa = value; }



        // METODOS

     




        // -------------------





        //FUNCIONES 

        public DataTable Listar()
        {
            return new DataTable();
        }



        //----------
    }
}



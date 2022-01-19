using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Cooperativa.Clases
{
    internal class BusMarca
    {
        //****************************** Variables **********
        int id;
        string marca;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        //----------------------------------------------------------

        //****************************Funciones*********************
        public DataTable ListarMarcas()
        {

            return new DataTable();
        }



        //----------------------------------------------------------.



        //************************Metodos***************************

        public void AgregarMarca()
        {

        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }






        //**********************************************************


    }
}

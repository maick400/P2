using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto.Cooperativa.Clases
{
    internal class Chofer:Personal
    {
        string licencia;
        bool estado;

        public string Licencia { get => Licencia; set => Licencia = value; }
        public bool Estado { get => estado; set => estado = value; }




        // METODOS

        public void Agregar()
        {
            
        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }





        // -------------------





        //FUNCIONES 

        public DataTable ListarChoferes ()
        {
            return new DataTable();
        }



        //----------


    }
}

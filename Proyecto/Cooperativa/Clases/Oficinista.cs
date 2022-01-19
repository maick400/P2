using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto.Cooperativa.Clases
{
    internal class Oficinista:Personal
    {

        int id;
        
        char Area;
        decimal Sueldo;

        public int Id1 { get => id; set => id = value; }
        public char Area1 { get => Area; set => Area = value; }
        public decimal Sueldo1 { get => Sueldo; set => Sueldo = value; }
        





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

        public DataTable ListarOficinistas()
        {
            return new DataTable();
        }

        //----------

    }

}

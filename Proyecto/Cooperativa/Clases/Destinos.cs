using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto.Cooperativa.Clases
{
    internal class Destinos
    {
        int id;
        string destino;
        decimal Precio;

        public int Id { get => id; set => id = value; }
        public string Destino { get => destino; set => destino = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }







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

        public DataTable ListarDestinos()
        {
            return new DataTable();
        }

        //----------

    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Cooperativa.Clases
{
    class Encomienda
    {
        public int idecomienda { get; set; }
        Cooperativa idcooperativa { get; set; }
        Cliente idcliente { get; set; }
        public string destinatario { get; set; }
        public string destinopartida { get; set; }
        public string destinollegada { get; set; }
        public decimal precio {get;set;}
        public int peso { get; set; }
        public string estado { get; set; }
        public int nguia { get; set; }





        /*funcion*/
        public DataTable ListarEcomienda()
        {

            return new DataTable();
        }


        /*Metodos */
        public void AgregarEcomienda()
        {

        }

    }
}

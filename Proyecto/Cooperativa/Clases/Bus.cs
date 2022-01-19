using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Cooperativa.Clases
{
    internal class Bus
    {
        string id;
        int numeroBus;
        string placa;
        string año;
        int idCooperativa;
        BusModelo idModelo;
        bool estado;

        public string Id { get => id; set => id = value; }
        public int NumeroBus { get => numeroBus; set => numeroBus = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Año { get => año; set => año = value; }
        public int IdCooperativa { get => idCooperativa; set => idCooperativa = value; }
        public bool Estado { get => estado; set => estado = value; }
        internal BusModelo IdModelo { get => idModelo; set => idModelo = value; }
    }
}

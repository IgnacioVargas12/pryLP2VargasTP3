using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLP2VargasTP3
{
    internal class clsVector
    {
        //Declaración de un registro
        public struct RegCli
        {
            public Int32 CampoCodigo;
            public String CampoUsuario;
            public decimal CampoDeuda;
            public decimal CampoLimite;
        }

        //Declaración de vector
        static public RegCli[] vecClientes = new RegCli[10];

        //Declaración de indice
        static public Int32 IND = 0;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Metodo de precarga
        static public void Precarga()
        {
            vecClientes[IND].CampoCodigo = 10;
            vecClientes[IND].CampoUsuario = "Ana";
            vecClientes[IND].CampoDeuda = 500;
            vecClientes[IND].CampoLimite = 10000;
            IND++;
            vecClientes[IND].CampoCodigo = 60;
            vecClientes[IND].CampoUsuario = "Diego";
            vecClientes[IND].CampoDeuda = 0;
            vecClientes[IND].CampoLimite = 20000;
            IND++;
            vecClientes[IND].CampoCodigo = 30;
            vecClientes[IND].CampoUsuario = "Maria";
            vecClientes[IND].CampoDeuda = 3000;
            vecClientes[IND].CampoLimite = 30000;
            IND++;
            vecClientes[IND].CampoCodigo = 50;
            vecClientes[IND].CampoUsuario = "Pedro";
            vecClientes[IND].CampoDeuda = 2000;
            vecClientes[IND].CampoLimite = 50000;
            IND++;
        }

        static public void OrdenarCodigoAscendente() 
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoCodigo > vecClientes[i + 1].CampoCodigo)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }

        }

        static public void OrdenarCodigoDescendente()
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoCodigo < vecClientes[i + 1].CampoCodigo)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

        static public void OrdenarNombreAscendente() 
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoUsuario.CompareTo(vecClientes[i + 1].CampoUsuario) > 0)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

        static public void OrdenarNombreDescendente()
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoUsuario.CompareTo(vecClientes[i + 1].CampoUsuario) < 0)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

        static public void OrdenarDeudaAscendente() 
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoDeuda > vecClientes[i + 1].CampoDeuda)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

        static public void OrdenarDeudaDescendente() 
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoDeuda < vecClientes[i + 1].CampoDeuda)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        
        static public void OrdenarLimiteAscendente() 
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoLimite > vecClientes[i + 1].CampoLimite)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

        static public void OrdenarLimiteDescendente() 
        {
            Int32 C = 0;
            Int32 i = 0;
            RegCli Aux;

            while (C < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (vecClientes[i].CampoLimite < vecClientes[i + 1].CampoLimite)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
    }
}

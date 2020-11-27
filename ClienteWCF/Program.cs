using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializarlo 
            ServiceEmpresas.Service1Client cliente = new ServiceEmpresas.Service1Client();

            //variable que ayuda a 
            var empre = cliente.ObtenerEmpresa();


        }
    }
}

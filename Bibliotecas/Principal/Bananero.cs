using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Bananero
    {
        public static int ContadorBananos(int cajas, int cant)
        {
            return cajas * cant;
        }

        public static void MostrarColoresBananos()
        {
            Console.WriteLine("Hay bananos amarillos y verdes");
            Console.ReadLine();

        }


    }
}


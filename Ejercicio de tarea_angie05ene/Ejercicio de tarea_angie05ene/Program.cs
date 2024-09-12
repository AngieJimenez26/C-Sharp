using System;
using System.ComponentModel.Design;

namespace Ejercicio_de_tarea_angie05ene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que le aplique el descuento al valor de la matricula, mostramdole qué descuentos hay
            la persona debe elegir a cuales aplica
             el sistema despúes de evaluar eso aplicará solo un descuento, el de mayor porcentaje
            usar boleanos*/

            double valorMatricula = 3400000;
            bool opcion1 = false;
            bool opcion2 = false;
            bool opcion3 = false;         
            double descuento1 = 0.05;
            double descuento2 = 0.04;
            double descuento3 = 0.06;
            double valorfinal = 0.0;
            string nameDescuento = "";


    
            Console.WriteLine("Tenemos 3 opciones de posibles descuentos a los que podrías aplicar");
            Console.WriteLine("1.Descuento por afiliación,escribe true para si y false para no");
            opcion1 = Convert.ToBoolean(Console.ReadLine()); 
            Console.WriteLine("2.Descuento para estratos 1 y 2,escribe true para si y false para no");
            opcion2= Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("3.Descuento para indigenas,escribe true para si y false para no");
            opcion3 = Convert.ToBoolean(Console.ReadLine());

            /*
            if (opcion3== true)
            {
                valorfinal = valorMatricula-(valorMatricula * descuento3);
                nameDescuento = "por el Descuento para indígenas";
            }
            else if (opcion1==true)
            {
                valorfinal = valorMatricula - (valorMatricula * descuento1);
                nameDescuento = "por el Descuento por afiliación";
            }
            else if (opcion2 == true)
            {
                valorfinal = valorMatricula - (valorMatricula * descuento2);
                nameDescuento = "por el Descuento por estrato";
            }
            else
            {
                valorfinal = valorMatricula;
                nameDescuento = "porque no aplicaste a ningún descuento";
            }
            Console.WriteLine("El valor final de su matricula es de {0} {1}",valorfinal,nameDescuento);
            */

           double sumaPorcentaje= 0.0;


            if (opcion1== true)
            {
                sumaPorcentaje = sumaPorcentaje + descuento1;
            }

            if (opcion2 == true)
            {
                sumaPorcentaje = sumaPorcentaje + descuento2;
            }

            if (opcion3 == true)
            {
                sumaPorcentaje = sumaPorcentaje + descuento3;
            }

            valorfinal =valorMatricula- (valorMatricula * sumaPorcentaje);
            Console.WriteLine(""valorfinal);



























        }
    }
}
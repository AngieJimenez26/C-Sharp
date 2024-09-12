namespace Ejercicio_angie06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que diga si un número es par o impar

            double ingreum = 0.0;
            

            Console.WriteLine( " Por favor ingresa un número y te diré si es par o impar");
            ingreum = Convert.ToDouble(Console.ReadLine());

            if (ingreum % 2 == 0)
                Console.WriteLine("{0} es un número par", ingreum);
            if (ingreum % 2 != 0)
                Console.WriteLine("¨{0} es un número impar", ingreum);
            Console.WriteLine("Fin");                               

                                    
        }
    }
}
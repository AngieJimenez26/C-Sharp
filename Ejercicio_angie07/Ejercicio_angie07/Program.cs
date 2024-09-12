namespace Ejercicio_angie07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ingreum = 0.0;


            Console.WriteLine(" Por favor ingresa un número y te diré si es par o impar");
            ingreum = Convert.ToDouble(Console.ReadLine());

            if (ingreum % 2 == 0)
                Console.WriteLine("{0} es un número par", ingreum);
            else
                Console.WriteLine("{0} es un número impar", ingreum);

        }
    }
}
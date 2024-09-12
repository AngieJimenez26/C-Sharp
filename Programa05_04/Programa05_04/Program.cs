namespace Programa05_04
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // cconvertir grados celsius a Fahrenheit
            // declrar variablES
            double celsius = 40;
            double fah = 0.0;

            // convertir
            fah = (1.8 * celsius) + 32;
            Console.WriteLine("{0} grados celsius son {1} grados fahrenheit", celsius,fah);

        }
    }
} 
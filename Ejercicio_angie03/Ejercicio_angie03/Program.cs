namespace Ejercicio_angie03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesosc = 0.0;
            double dolares = 0.00023;
            double conversor = 0.0;

            Console.WriteLine(" ingrese el valor a convertir en pesos colombianos");
            pesosc = Convert.ToDouble(Console.ReadLine());
            conversor = pesosc * dolares;
            Console.WriteLine("tienes {0} dolares", conversor);
        

            
            
        }
    }
}
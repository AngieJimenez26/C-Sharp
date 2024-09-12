namespace Ejercicio_angie04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que calcule el promedio de 3 números.
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double prome = 0.0;

            Console.WriteLine("Por favor dame el primer número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor dame el segundo número");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor dame el tercer número");
            num3 = double.Parse(Console.ReadLine());
            prome = (num1 + num2 + num3) / 3;
            Console.WriteLine("El promedio de los 3 números es:{0}", prome);
            if (num1 == num2)
                Console.WriteLine("El num 1 y num 2 son iguales, Aprendí el IF perro");
            else 
                Console.WriteLine("El num 1 y num 2 no son iguales, Aprendí mas perro");


            

        }
    }
}
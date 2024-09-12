namespace Programa05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que calcule el área y el perimetro de un cuadrado
            // definir variables

            double lado = 5;
            double area = 0.0;
            double perimetro = 0.0;

            // calcular area
            area = lado * lado;

            // calculas perimetro
            perimetro = lado * 4;

            // mostrar resultados

            Console.WriteLine( "El área de un cuadrado de lado {0} es {1}",lado,area);
            Console.WriteLine("El perimetro del cuadrado es: {0}", perimetro);




        }
    }
}
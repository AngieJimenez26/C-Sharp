namespace Ejercicio_angie02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // programa que calcule el area y perimetro de un rectangulo.
            double largo = 0;
            double ancho = 0;
            double area = 0;
            double perimetro = 0;

            Console.WriteLine("Por favor dame el largo del rectángulo");
            largo = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine(" Por favor dame el ancho del rectángulo");
            ancho = Convert.ToDouble(Console.ReadLine());
            area = largo * ancho;
            Console.WriteLine("El área del rectángulo es {0}", area);
            perimetro = largo * 2 + ancho * 2;
            Console.WriteLine("El perimetro es {0}",perimetro);
            
        }
    }
}
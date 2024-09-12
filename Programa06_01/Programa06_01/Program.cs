namespace Programa06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string nombre = "";
            string apellido = "";
            int anio = 0;
            int adivinar = 2023;
            int añoper = 0;





            // pedir nombre
            Console.WriteLine("Por favor escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Qué bonito nombres tienes {0}", nombre);
            Console.WriteLine("Por favor escribe tu apellido {0}",nombre);
            apellido = Console.ReadLine();
            Console.WriteLine("{0} {1} eres muy amable", nombre, apellido);

            Console.WriteLine("Ahora {0}, por favor escribe tu año de nacimiento y te diré que edad tienes", nombre);
            anio = int.Parse(Console.ReadLine());
            añoper = adivinar - anio;

            Console.WriteLine("{0}, tu edad es {1} maraquitas",nombre, añoper);

            // mandar saludo

            Console.WriteLine("Gracias por ayudarme a aprender {0} {1}", nombre, apellido);
            Console.WriteLine("Vuelve pronto");


        }
    }
}
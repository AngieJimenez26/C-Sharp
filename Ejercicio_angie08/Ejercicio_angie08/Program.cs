namespace Ejercicio_angie08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir edad si es mayor de 18 hacer lo que dice if y si no hacer lo que dice else

            int edad = 0;
            string nombre = "";
            string ciudad = "";
            int diferencia = 0;


            Console.WriteLine(" Hola estás participando por la rifa de un carro Cx30 0 kilometros");
            Console.WriteLine(" por favor ingresa tu edad");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >=18 )
               {
                Console.WriteLine(" dame tu nombre y apellido");
                nombre = Console.ReadLine();

                Console.WriteLine("{0} de qué ciudad eres",nombre);
                ciudad = Console.ReadLine();
                Console.WriteLine("{0} {1} es una ciudad realmente hermosa",nombre,ciudad);

                Console.WriteLine(" Con estos datos has quedado inscrito a nuestro sorteo, MUCHA SUEDTE");
            }
            else
            {
                diferencia = 18 - edad;
                Console.WriteLine("Lo siento te faltan {0} años para ser mayor de edad,no puedes participar",diferencia);
            }
        }
    }
}
namespace Ejercicio_angie09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para participar en un sorteo de un carro, se pudee participar si es hombre mayor de 18
            // mujer mayor de 15 años

            // variables
            int edadsort = 0;
            string numtel = "";
            string genero = "";
            string nombre = "";
            string ciudad = "";
            bool tieneHermanos = false;
            string nombreherm = "";

            Console.WriteLine("Hola estás participando por la rifa de un carro 0 Kilometros!!!");
            Console.WriteLine("Por favor ingresa tu edad");
            edadsort = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("eres hombre o mujer?");
            genero = Console.ReadLine();
            if ((edadsort >= 18 && genero == "hombre") || (edadsort >= 15 && genero == "mujer"))

            {
                Console.WriteLine("Dame tu nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("{0} por favor dame tu número de telefono", nombre);
                numtel = Console.ReadLine();
                Console.WriteLine("¿Tienes hermanos?");
                Console.WriteLine("Escribe true para si y false para no");
                tieneHermanos = Convert.ToBoolean(Console.ReadLine());/*true o false*/


                if (tieneHermanos == false)
                {
                    Console.WriteLine("No hay problema solo participas tú");
                    Console.WriteLine("hasta la próxima {0}, mucha suerte", nombre);
                }
                else
                {
                
                    Console.WriteLine("{0},dameel nombre de tu herman@ por premios sorpresa",nombre);
                    nombreherm = Console.ReadLine();
                    Console.WriteLine("{0}, tu herman@ {1} ya quedó inscrit@, muchas gracias por participar",nombre,nombreherm);
                 }

                
            }
            else
            {
                Console.WriteLine("No pudes participar, no cumples la edad necesaria");

            }








            
        }
    }
}
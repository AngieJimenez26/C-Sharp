namespace Programa06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string dato = "";
            int valor = 0;

            // pedir un número

            Console.WriteLine("por favo digita un número");
            dato = Console.ReadLine();
            valor = Convert.ToInt32(dato);
            Console.WriteLine("el número es {0}", valor);


            
            

        }

        
    }
}
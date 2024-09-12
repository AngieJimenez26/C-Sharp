namespace Ejercicio_angie05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // realizar las 4 operaciones bàsicas segùn lo requiera el usuario, usando dos numeros.

            // Variables
            // pedri num 1
            // pedir num 2
            // pedir operación
            // determinar si es +
            // determinar si es resta
            // determinar si es *
            // detnerminar si es /
            // mostrar el resultado

            
            double numerito1 = 0.0;
            double numerito2= 0.0;
            int operacion = 0;
            double resultadito = 0.0;

            Console.WriteLine("Por favor dame el número 1");
            numerito1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Por favoir dame el nùmero 2");
            numerito2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ¿Què operación deseas realizar?");
            Console.WriteLine("¿1.suma, 2.resta, 3.multiplicación o 4.división?");
            operacion = Convert.ToInt32(Console.ReadLine());
            if (operacion == 1)
            
                resultadito = numerito1 + numerito2;
             
            if (operacion == 2)
                resultadito = numerito1 - numerito2;

            if(operacion == 3)
                resultadito = numerito1 * numerito2;

            if(operacion == 4)
                resultadito = numerito1 / numerito2;
            if (operacion > 4)
                Console.WriteLine("Esta opción es inválida ");

            else

                Console.WriteLine("El resultado es {0}", resultadito);















        }
    }
}
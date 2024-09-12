namespace Programa05_05
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // calcular área total de una casa con 3 habitaciones
            // variables
            double ancho1 = 4.3;
            double largo1 = 4.0;
            double area1 = 0.0;

            double ancho2 = 5.0;
            double largo2 = 6.7;
            double area2 = 0.0;

            double ancho3 = 2.89;
            double largo3 = 3.54;
            double area3 = 0.0;
            double area_total = 0.0;






            // cslcular área habitación 1
            area1 = ancho1 * largo1;

            // calcular área habitación 2

            area2 = ancho2 * largo2;

            //calcular  área habitación 3
            area3 = ancho3 * largo3;

            // calcular área total
            area_total = area1 + area2 + area3;
            

            // mostrar resultado

            Console.WriteLine(" el area total de la casa es {0}", area_total);

        }
    }
}
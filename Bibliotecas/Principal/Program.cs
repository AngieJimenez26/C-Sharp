

namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int cantidadTotal = Bananero.ContadorBananos(5, 20);
          Console.WriteLine("Total Bananos:" + cantidadTotal);
          Bananero.MostrarColoresBananos();
        }
    }
}
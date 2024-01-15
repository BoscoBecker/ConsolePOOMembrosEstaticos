using System;
using System.Globalization;

namespace ConsolePOOMembrosEstaticos
{
  internal class Program
  {
    static double Pi = 3.14;

    static void Main(string[] args)
    {
      Console.Write("Informe o valor do raio:" );
      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double circuferencia = Circuferencia(raio);
      Console.WriteLine("Circuferencia : " + circuferencia.ToString("F2",CultureInfo.InvariantCulture));
      
      double volume = Volume(raio);
      Console.WriteLine("O Volume é:" + volume.ToString("F2",CultureInfo.InvariantCulture));
      Console.WriteLine("O valor de Pi é: "+Pi.ToString("F2",CultureInfo.InvariantCulture));
    
    }

    static double Circuferencia(double raio)
    {
      return 2.0 * Pi * raio;

    }
    static double Volume(double raio) {
      return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
    }
  }
}

using System;
using System.Globalization;

namespace consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotal;
            double combustivelTotal, consumoMedio;

            distanciaTotal = int.Parse(Console.ReadLine());
            combustivelTotal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            consumoMedio = distanciaTotal / combustivelTotal;
            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) +  " km/l");
        }
    }
}

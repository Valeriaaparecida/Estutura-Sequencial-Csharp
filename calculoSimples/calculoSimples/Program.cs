using System;
using System.Globalization;

namespace calculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            
           double total;
           string[] v = Console.ReadLine().Split(' ');
           string[] c = Console.ReadLine().Split(' ');

           int cod1 = int.Parse(v[0]);
           int  qte1 = int.Parse(v[1]);
           double preco1 = double.Parse(v[2], CultureInfo.InvariantCulture);

           int cod2 = int.Parse(c[0]);
           int qte2 = int.Parse(c[1]);
           double preco2 = double.Parse(c[2], CultureInfo.InvariantCulture);

           total = preco1 * qte1 + preco2 * qte2;

           Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
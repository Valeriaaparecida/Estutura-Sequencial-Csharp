using System;
using System.Globalization;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDoFuncionario, horasTrabalhadas;
            double valorPorHora, SALARY;

            numeroDoFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = valorPorHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = " +  numeroDoFuncionario);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2" , CultureInfo.InvariantCulture));
            Console.ReadLine(); 
        }
    }
}


using System;
using System.Globalization;

namespace PrimeiroProjeto
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, me diga seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("E quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um preço");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
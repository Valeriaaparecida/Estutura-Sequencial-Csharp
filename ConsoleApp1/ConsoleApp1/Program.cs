using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;
            string nome;
            Console.WriteLine("Olá! Qual é seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine(nome + " digite um valor");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine(nome + " digite outro valor");
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("Parabéns Valéria! O resultado da soma de "  + A + " + "  + B  + " é : " + X );

            

        }
    }
}
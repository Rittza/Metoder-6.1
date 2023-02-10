using System;
using System.Transactions;

namespace Inlämmningsppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett sista tal");
            int tal3 = int.Parse(Console.ReadLine());
            int summan = Addera(tal1, tal2, tal3);
            Console.WriteLine(summan);
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            int summan = tal1 + tal2 + tal3;
            return summan;
        }
    }
}
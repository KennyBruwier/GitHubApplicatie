using System;

namespace GitHubApplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Leeftijd: ");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
        }
    }
}

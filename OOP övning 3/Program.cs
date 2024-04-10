using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Namn p = new Namn();
        Console.WriteLine("Förnamn?");
        p.Förnamn = Console.ReadLine();
        Console.WriteLine("Efternamn?");
        p.Efternamn = Console.ReadLine();
        p.FullNamn();
        Console.WriteLine(p.Ålder());

    }
}

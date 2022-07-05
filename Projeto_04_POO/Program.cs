using System;

namespace Projeto_04_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Homem h1 = new Homem("Felipe",60);
            Console.WriteLine(h1.apresentar());
            Console.WriteLine(h1.fazerAniversario());
            Console.WriteLine(h1.fazerBarba());
            Console.WriteLine(h1.aposentar());
            Console.WriteLine(h1.colocarImplante());
            Console.WriteLine(h1.apresentar());

            Console.WriteLine("\n----------------------\n");

            Mulher m1 = new Mulher("Karol", 60);
            Console.WriteLine(m1.apresentar());
            Console.WriteLine(m1.fazerAniversario());
            Console.WriteLine(m1.engravidar());
            Console.WriteLine(m1.getGravida());
            Console.WriteLine(m1.aposentar());
        }
    }
}

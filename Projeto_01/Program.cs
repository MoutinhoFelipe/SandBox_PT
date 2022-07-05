using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nDigite um nome:");
                string name = Console.ReadLine();

                while (name.Length == 0)
                {
                    Console.WriteLine("Digite um nome:");
                    name = Console.ReadLine();
                }

                //Console.WriteLine("Passou aqui");

                char[] characteres = name.ToCharArray();
                char[] letra = { 'a', 'à', 'á', 'ã', 'â', 'ä', 'ª', 'e', 'é', 'è', 'ê', 'ë'};

                int i = 0;

                while (i < letra.Length)
                {

                    if (char.ToUpperInvariant(characteres[0]) == char.ToUpperInvariant(letra[i]))
                    {
                        Console.WriteLine("A primeira letra do nome é: " + letra[i]);

                        string nome = "Felipe";

                        Console.WriteLine($"A primeira letra do nome é: {nome} " );
                        break;
                    }
                    i++;
                }

                i = 0;



                //while (i < letra.Length)
                //{
                //    if (name.Length > 1)
                //    {
                //        if (char.ToUpperInvariant(characteres[1]) == char.ToUpperInvariant(letra[i]))
                //        {
                //            Console.WriteLine("A segunda letra do nome é: " + letra[i]);
                //        }
                //    }
                //    i++;
                //}

                if (name.Length > 1)
                {
                    if (letra.Contains(char.ToLower(characteres[1])))
                    {
                        Console.WriteLine("A segunda letra do nome é: " + characteres[1]);
                    }
                }

                i = 0;

                while (i < letra.Length)
                {
                    if (char.ToUpperInvariant(characteres[name.Length - 1]) == char.ToUpperInvariant(letra[i]))
                    {
                        Console.WriteLine("A última letra do nome é: " + letra[i]);
                    }
                    i++;
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimaHora.Models;

namespace UltimaHora
{
    internal class RelatorioController
    {
        public RelatorioController()
        {

        }

        public void criarRelatorio(List<Cliente> clientes)
        {
            string path = @"C:\Users\otavi\source\repos\_Moutinho\SandBox_PT\UltimaHora\Relatorio2.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (var item in clientes)
                    {
                        sw.WriteLine(item.Nome);
                    }
                    
                }
            }

            //// Open the file to read from.
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
        }
    }
}

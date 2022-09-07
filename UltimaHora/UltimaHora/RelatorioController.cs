using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimaHora.Models;

namespace UltimaHora
{
    public class RelatorioController
    {
        public RelatorioController() { }

        public static void gerarRelatorioComprasPorClientes()
        {
            AppDbContext dbContext = new AppDbContext();
            var relatorioComprasPorCliente = dbContext.Venda.GroupBy(v => new { v.IdClienteNavigation.Id, v.IdClienteNavigation.Nome})
                                                            .Select(g => new { Cliente = g.Key.Nome, Contador = g.Count() });

            string path = @"C:\Users\otavi\source\repos\_Moutinho\SandBox_PT\UltimaHora\RelatorioComprasPorClientes.txt";
            
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("\nRelatório com Quantidade de Compras por Cliente: ");
                    sw.WriteLine("Relatório com Quantidade de Compras por Cliente: ");
                    sw.WriteLine("Cliente   Compras");
                    foreach (var item in relatorioComprasPorCliente)
                    {
                        Console.WriteLine(item);
                        sw.WriteLine($"{item.Cliente}   {item.Contador}");
                    }
                }
        }

        public static void gerarRelatorioVendasPorProduto()
        {
            AppDbContext dbContext2 = new AppDbContext();
            var relatorioContadorVendasPorProduto = dbContext2.VendaProdutos
                                                               .GroupBy(vp => vp.IdProdutoNavigation.Nome)
                                                               .Select(g => new { Produto = g.Key, Contador = g.Count() });

            string path = @"C:\Users\otavi\source\repos\_Moutinho\SandBox_PT\UltimaHora\RelatorioVendasPorProduto.txt";

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                Console.WriteLine("\nRelatório com Quantidade de Produtos Vendidos: ");
                sw.WriteLine("Relatório com Quantidade de Produtos Vendidos: ");
                sw.WriteLine("Produto   Quantidade");
                foreach (var item in relatorioContadorVendasPorProduto)
                {
                    Console.WriteLine(item);
                    sw.WriteLine($"{item.Produto}   {item.Contador}");
                }
            }
        }

        private static void PopulaBanco()
        {
            Cliente cliente = new Cliente()
            {
                Nome = "Tati"
            };

            Produto produto = new Produto()
            {
                Id = 1,
                Nome = "Teclado",
                Preco = 80.00
            };

            Vendum venda = new Vendum()
            {
                Id = 1,
                IdCliente = 4,
                DataHora = DateTime.Now
            };

            VendaProduto vendaProduto = new VendaProduto()
            {
                IdProduto = 1,
                IdVenda = 1,
            };

            AppDbContext dbContext = new AppDbContext();
            //dbContext.Clientes.Add(cliente);
            dbContext.Produtos.Add(produto);
            dbContext.Venda.Add(venda);
            dbContext.VendaProdutos.Add(vendaProduto);
            dbContext.SaveChanges();
        }
    }
}

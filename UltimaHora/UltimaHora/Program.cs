using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using UltimaHora.Models;

namespace UltimaHora
{
    public class Program
    {
        public static void Main(string[] args)
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
            var c1 = dbContext.Clientes.ToList();

            RelatorioController r1 = new RelatorioController();
            r1.criarRelatorio(c1);
        }


    }
}

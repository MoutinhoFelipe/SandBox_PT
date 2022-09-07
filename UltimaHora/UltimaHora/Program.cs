using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using UltimaHora.Models;
//using UltimaHora.Models;

namespace UltimaHora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RelatorioController RelatorioController = new RelatorioController();
            RelatorioController.gerarRelatorioComprasPorClientes();
            RelatorioController.gerarRelatorioVendasPorProduto();

        }
    }
}

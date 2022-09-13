using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Services;

namespace Calculadora
{
    public class Client
    {
        ICalculadoraService _calculadoraService;
        public Client(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }



        public void processarSoma(TabelaCalculos tabela, Calculo calculo)
        {
            var soma = _calculadoraService.Somar(calculo.PrimeiroNumero, calculo.SegundoNumero);
            Console.WriteLine($"A Soma é {soma}");
            tabela.InsertCalculo(calculo);
        }

        public void processarSubtracao(TabelaCalculos tabela, Calculo calculo)
        {
            var subtracao = _calculadoraService.Subtrair(calculo.PrimeiroNumero, calculo.SegundoNumero);
            Console.WriteLine($"A Subtração é {subtracao}");
            tabela.InsertCalculo(calculo);
        }

        public void processarMultiplicacao(TabelaCalculos tabela, Calculo calculo)
        {
            Console.WriteLine($"A Multiplicação é {_calculadoraService.Multiplicar(calculo.PrimeiroNumero, calculo.SegundoNumero)}");
            tabela.InsertCalculo(calculo);
        }
        public void processarDivisao(TabelaCalculos tabela, Calculo calculo)
        {
            Console.WriteLine($"A Divisão é {_calculadoraService.Dividir(calculo.PrimeiroNumero, calculo.SegundoNumero)}");
            tabela.InsertCalculo(calculo);
        }
    }
}

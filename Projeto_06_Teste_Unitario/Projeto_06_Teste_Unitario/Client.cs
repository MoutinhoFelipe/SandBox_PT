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
            Console.WriteLine($"A Soma é {_calculadoraService.Somar(calculo.PrimeiroNumero, calculo.SegundoNumero)}");
            tabela.InsertCalculo(calculo);
        }
        public void processarSubtrair(TabelaCalculos tabela, Calculo calculo)
        {
            Console.WriteLine($"A Subtração é {_calculadoraService.Somar(calculo.PrimeiroNumero, calculo.SegundoNumero)}");
            tabela.InsertCalculo(calculo);
        }
        public void processarMultiplicar(TabelaCalculos tabela, Calculo calculo)
        {
            Console.WriteLine($"A Multiplicação é {_calculadoraService.Multiplicar(calculo.PrimeiroNumero, calculo.SegundoNumero)}");
            tabela.InsertCalculo(calculo);
        }
        public void processarDividir(TabelaCalculos tabela, Calculo calculo)
        {
            Console.WriteLine($"A Divisão é {_calculadoraService.Dividir(calculo.PrimeiroNumero, calculo.SegundoNumero)}");
            tabela.InsertCalculo(calculo);
        }
    }
}

using Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Cliente
    {
        ICalculadoraService _calculadoraService;
        public Cliente(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        public void processarSoma()
        {
            Console.WriteLine(_calculadoraService.Somar(10, 5));
                
        }
        public void processarSubtrair()
        {
            Console.WriteLine(_calculadoraService.Subtrair(10, 5));

        }
        public void processarMultiplicar()
        {
            Console.WriteLine(_calculadoraService.Multiplicar(10, 5));

        }
        public void processarDividir()
        {
            Console.WriteLine(_calculadoraService.Dividir(10, 5));

        }
    }
}

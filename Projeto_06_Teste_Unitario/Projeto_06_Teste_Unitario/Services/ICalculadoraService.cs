using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public interface ICalculadoraService
    {
        double Somar(double n1, double n2);
        double Subtrair(double n1, double n2);
        double Multiplicar(double n1, double n2);
        double Dividir(double n1, double n2);
    }
}

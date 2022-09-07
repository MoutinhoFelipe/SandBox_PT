

using Calculadora;
using Calculos;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_06_Teste_Unitario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new Cliente(new CalculadoraMaluca());

            cliente.processarSoma();
            cliente.processarSubtrair();
            cliente.processarMultiplicar();
            cliente.processarDividir();

        }
    }
}

    


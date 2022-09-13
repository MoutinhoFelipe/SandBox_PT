using Calculadora;
using Calculadora.Services;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client(new CalculadoraService());
            TabelaCalculos tabelaCalculos = new TabelaCalculos();
            Calculo calculo1 = new Calculo()
            {
                Id = 1,
                TipoOperacao = "Soma",
                PrimeiroNumero = 15,
                SegundoNumero = 10
            };
            Calculo calculo2 = new Calculo()
            {
                Id = 2,
                TipoOperacao = "Subtração",
                PrimeiroNumero = 50,
                SegundoNumero = 30
            };

            client.processarSoma(tabelaCalculos, calculo1);
            client.processarSubtracao(tabelaCalculos, calculo2);

            //Listar todos itens da Lista
            foreach (var item in tabelaCalculos.GetCalculos())
            {
                Console.WriteLine($"Id: {item.Id} | Tipo de Operação: {item.TipoOperacao} | Primeiro Número: {item.PrimeiroNumero} | Segundo Número: {item.SegundoNumero}");
            }
            
        }
    }
}

    


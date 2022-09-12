using Calculadora.Services;
using NSubstitute;
using Xunit;

namespace Calculadora.Testes
{
    public class ClienteTest
    {
        [Fact]
        public void processarSoma_ChamaICalculadoraService_RecebeCalculo_Soma_RetornaVoid()
        {
            //Arrange
            var calculadoraService = NSubstitute.Substitute.For<ICalculadoraService>();
            var calculo = NSubstitute.Substitute.For<Calculo>();


            calculadoraService.Somar(10, 5).Returns(15);

            //Act
            Client cliente = new Client(calculadoraService);
            cliente.processarSoma();

            //Assert
            calculadoraService.Received(1).Somar(10, 5);
            
        }
    }
}
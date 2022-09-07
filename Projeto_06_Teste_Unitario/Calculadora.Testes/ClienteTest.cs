using Calculos;
using NSubstitute;
using Xunit;

namespace Calculadora.Testes
{
    public class ClienteTest
    {
        [Fact]
        public void processarSoma_chamaICalculadoraService_somar_retornavoid()
        {
            //Arrange
            var calculadoraService = NSubstitute.Substitute.For<ICalculadoraService>();
            calculadoraService.Somar(10, 5).Returns(15);

            //Act
            Cliente cliente = new Cliente(calculadoraService);
            cliente.processarSoma();

            //Assert
            calculadoraService.Received(1).Somar(10, 5);
            
        }
    }
}
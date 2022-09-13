using Calculadora.Services;
using Xunit;

namespace Calculadora.Testes
{

    public class CalculadoraServiceTest
    {
        private CalculadoraService _calculadoraService = new CalculadoraService();

        [Fact]
        public void Somar_DoisDoubles_RetornaDouble()
        {
            //Arrange
            double n1 = 2.5;
            double n2 = 7.5;
            double resultadoEsperado = 10;

            //Act
            var result = _calculadoraService.Somar(n1, n2);

            //Assert
            Assert.Equal(resultadoEsperado, result);
        }

        [Fact]
        public void Subtrair_DoisDoubles_RetornaDouble_()
        {
            //Arrange
            double n1 = -30;
            double n2 = -20;
            double resultadoEsperado = -10;

            //Act
            var result = _calculadoraService.Subtrair(n1, n2);

            //Assert
            Assert.Equal(resultadoEsperado, result);
        }
    }
}
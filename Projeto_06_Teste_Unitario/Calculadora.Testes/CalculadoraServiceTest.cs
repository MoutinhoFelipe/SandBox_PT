using Calculadora.Services;
using Xunit;

namespace Calculadora.Testes
{
    public class CalculadoraServiceTest
    {
        [Fact]
        public void Somar_DoisDoubles_RetornaDouble()
        {
            //Arrange
            double n1 = 2.5;
            double n2 = 7.5;
            double resultadoEsperado = 10;

            //Act
            CalculadoraService calculadora = new CalculadoraService();
            var result = calculadora.Somar(n1, n2);

            //Assert
            Assert.Equal(resultadoEsperado, result);
        }

        [Fact]
        public void Somar_DoisDoubles_RetornaDouble_()
        {
            //Arrange
            double n1 = 0;
            double n2 = 0;
            double resultadoEsperado = 0;

            //Act
            CalculadoraService calculadora = new CalculadoraService();
            var result = calculadora.Somar(n1, n2);

            //Assert
            Assert.Equal(resultadoEsperado, result);
        }
    }
}
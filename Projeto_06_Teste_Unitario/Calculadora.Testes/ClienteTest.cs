using Calculadora.Services;
using FizzWare.NBuilder;
using NSubstitute;
using Xunit;

namespace Calculadora.Testes
{
    public class ClienteTest
    {
        private Client _client;
        private ICalculadoraService _calculadoraServiceMocked = Substitute.For<ICalculadoraService>();
        private TabelaCalculos _tabelaCalculosMocked = Substitute.For<TabelaCalculos>();   

        public ClienteTest()
        {
            _client = new Client(_calculadoraServiceMocked);
        }

        [Fact]
        public void processarSoma_UsaICalculadoraService_RecebeTabela_RecebeCalculo_ChamaSomar_RetornaVoid()
        {

            //Arrange
            var _calculoBuilded = Builder<Calculo>.CreateNew().With(x => x.PrimeiroNumero = 4)
                                                              .With(x => x.SegundoNumero = 7)
                                                              .Build();

            //Act
            _client.processarSoma(new TabelaCalculos(), _calculoBuilded);

            //Assert
            //Se o método processarSoma está executando o método Somar com os mesmos parâmetros
            _calculadoraServiceMocked.Received(1).Somar(_calculoBuilded.PrimeiroNumero, _calculoBuilded.SegundoNumero);
            
        }

        [Fact]
        public void processarSoma_RecebeTabela_RecebeCalculo_ChamaInsertCalculo_RetornaVoid()
        {
            //Arrange 
            var _calculoBuilded = Builder<Calculo>.CreateNew().With(x => x.PrimeiroNumero = 3)
                                                              .With(x => x.SegundoNumero = 5)
                                                              .Build();

            //Act
            _client.processarSoma(_tabelaCalculosMocked, _calculoBuilded);

            //Assert
            //Se o método processarSoma está executando o método InsertCalculo com os mesmos parametros
            _tabelaCalculosMocked.Received(1).InsertCalculo(_calculoBuilded);

        }

        [Fact]
        public void processarSubtracao_UsaICalculadoraService_RecebeTabela_RecebeCalculo_ChamaSubtrair_RetornaVoid()
        {
            //Arrange
            var _calculoBuilded = Builder<Calculo>.CreateNew().Build();

            //Act
            _client.processarSubtracao(new TabelaCalculos(), _calculoBuilded);

            //Assert
            _calculadoraServiceMocked.Received(1).Subtrair(_calculoBuilded.PrimeiroNumero, _calculoBuilded.SegundoNumero);
        }

        [Fact]
        public void processarSubtracao_RecebeTabela_RecebeCalculo_ChamaInsertCalculo_RetornaVoid()
        {
            //Arrange
            var _calculoBuilded = Builder<Calculo>.CreateNew().Build();

            //Act
            _client.processarSubtracao(_tabelaCalculosMocked, _calculoBuilded);

            //Assert
            _tabelaCalculosMocked.InsertCalculo(_calculoBuilded);
        }
    
    }
}
using Calculadora.Services;

namespace CalculadoraTest.Services
{
    public class CalculadoraServiceTests
    {
        private readonly CalculadoraService _calculadoraService;

        public CalculadoraServiceTests()
        {
            _calculadoraService = new CalculadoraService();
        }

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-5, -3, -8)]
        [InlineData(0, 0, 0)]
        public void Somar_DeveRetornarSomaCorreta(double num1, double num2, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadoraService.Somar(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 4, 6)]
        [InlineData(-5, -3, -2)]
        [InlineData(0, 0, 0)]
        public void Subtrair_DeveRetornarSubtracaoCorreta(double num1, double num2, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadoraService.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(7, 3, 21)]
        [InlineData(-5, -3, 15)]
        [InlineData(0, 5, 0)]
        public void Multiplicar_DeveRetornarMultiplicacaoCorreta(double num1, double num2, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadoraService.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(20, 4, 5)]
        [InlineData(-10, -2, 5)]
        [InlineData(0, 1, 0)]
        public void Dividir_DeveRetornarDivisaoCorreta(double num1, double num2, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadoraService.Dividir(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(-10, 0)]
        public void Dividir_DivisaoPorZero_DeveLancarExcecao(double num1, double num2)
        {
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculadoraService.Dividir(num1, num2));
        }
    }
}

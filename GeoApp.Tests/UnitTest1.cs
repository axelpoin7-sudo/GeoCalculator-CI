using Xunit;
using GeoApp.Models;

namespace GeoApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAreaRectangulo()
        {
            // Prueba que 10 * 5 sea 50
            double resultado = Calculadora.AreaRectangulo(10, 5);
            Assert.Equal(50, resultado);
        }

        [Fact]
        public void TestAreaCirculo()
        {
            // Prueba con radio 1, el resultado debe ser PI
            double resultado = Calculadora.AreaCirculo(1);
            Assert.Equal(Math.PI, resultado, 5);
        }

        [Fact]
        public void TestAreaTriangulo()
        {
            // Prueba (10 * 5) / 2 = 25
            double resultado = Calculadora.AreaTriangulo(10, 5);
            Assert.Equal(25, resultado);
        }
    }
}
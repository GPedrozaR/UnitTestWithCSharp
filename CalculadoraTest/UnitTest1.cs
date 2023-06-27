using Calculadora.Services;

namespace CalculadoraTest
{
    public class UnitTest1
    {
        private readonly Methods _method;
        public UnitTest1()
        {
            _method = new Methods();
        }

        [Fact]
        public void SumBetweenTwoNumbersTest()
        {
            var numberOne = 5;
            var numberTwo = 10;

            var sum = _method.Somar(numberOne, numberTwo);

            Assert.Equal(15, sum);
        }

        [Fact]
        public void NumberIsPairTest()
        {
            var numberOne = 1;
            var numberTwo = 2;

            var numberOneIsPair = _method.NumberIsPair(numberOne);
            var numberTwoIsPair = _method.NumberIsPair(numberTwo);

            Assert.True(numberOneIsPair);
            Assert.True(numberTwoIsPair);
        }
    }
}
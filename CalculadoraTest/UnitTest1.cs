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
        public void NumberIsPairTestWithoutParam()
        {
            var numberOne = 1;
            var numberTwo = 2;

            var numberOneIsPair = _method.NumberIsPair(numberOne);
            var numberTwoIsPair = _method.NumberIsPair(numberTwo);

            Assert.True(numberOneIsPair);
            Assert.True(numberTwoIsPair);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void NumberIsPairTestWithParam(int number)
        {
            var numberOneIsPair = _method.NumberIsPair(number);
            Assert.True(numberOneIsPair);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 4, 5, 6, 7, 8 })]
        public void NumberIsPairTestWithParams(int[] numbers)
        {
            Assert.All(numbers, num => Assert.True(_method.NumberIsPair(num)));
        }
    }
}
using Calculadora.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTest
{
    public class StringValidationsTest
    {
        private readonly StringValidations _validations;

        public StringValidationsTest()
        {
            _validations = new StringValidations();
        }

        [Fact]
        public void CountStringLenghtTest()
        {
            var text = "HelloWorld";

            var lenght = _validations.StringCounter(text);

            Assert.Equal(10, lenght);
        }
    }
}

namespace Calculadora.Services
{
    public class Methods
    {
        public double Somar(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public bool NumberIsPair(int number)
        {
            return number % 2 == 0;
        }

        public double Subtrair(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Dividir(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public double Multiplicar(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcApp.CalculatorApp;

namespace CalcApp.Test.CalcAppTest
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 3, 5)]
        public void Calculator_Add_ReturnInt(int a, int b, int expected)
        {
            var Add = new Calculator();
            
            int res = Add.Add(a, b);
            
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 3, -1)]
        public void Calculator_Subtract_ReturnInt(int a, int b, int expected)
        {
            var Subtract = new Calculator();

            int res = Subtract.Subtract(a, b);

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 3, 6)]
        public void Calculator_Multiply_ReturnInt(int a, int b, int expected)
        {
            var Multiply = new Calculator();

            int res = Multiply.Multiply(a, b);

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 2, 5)]
        public void Calculator_Divide_ReturnFloat(int a, int b, float expected)
        {
            var Divide = new Calculator();

            float res = Divide.Divide(a, b);

            Assert.Equal(expected, res);
        }

        [Fact]
        public void Calculator_DivideByZero_ThrowsException()
        {
            int a = 5, b = 0;

            var calc = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));
        }
    }
}

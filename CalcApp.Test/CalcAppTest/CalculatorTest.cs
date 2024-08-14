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
        [Fact]
        public void Calculator_Add_ReturnInt()
        {
           
            int a = 1, b = 1;
            var Add = new Calculator();
            
            int res = Add.Add(a, b);
            
            Assert.Equal(2, res);
        }

        [Fact]
        public void Calculator_Subtract_ReturnInt()
        {
            int a = 1, b = 1;
            var Subtract = new Calculator();

            int res = Subtract.Subtract(a, b);

            Assert.Equal(0, res);
        }

        [Fact]
        public void Calculator_Multiply_ReturnInt()
        {
            int a = 2, b = 3;
            var Multiply = new Calculator();

            int res = Multiply.Multiply(a, b);

            Assert.Equal(6, res);
        }

        [Fact]
        public void Calculator_Divide_ReturnFloat()
        {
            int a = 4, b = 2;
            var Divide = new Calculator();

            float res = Divide.Divide(a, b);

            Assert.Equal(2, res);
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

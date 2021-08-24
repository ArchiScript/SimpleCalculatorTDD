using System;
using Xunit;
using SimpleCalculatorTDD;

namespace SimpleCalculatorTDD.Tests
{
    public class SimpleCalculatorTDDTest
    {
        [Fact]
        public void GetSum_3_Plus_2_Eq_5()
        {
            //Arrange 
            SimpleCalculatorTDDClass calc = new SimpleCalculatorTDDClass();

            //Act
            int result = calc.GetSum(3, 2);

            //Assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void GetSubstract_20_Minus_14_Eq_6()
        {
            //Arrange   
            SimpleCalculatorTDDClass calc = new SimpleCalculatorTDDClass();

            //Act
            int result = calc.GetSubstract(20, 14);

            //Assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void GetMultiply_7_Mult_8_Eq_56()
        {
            //Arrange 
            SimpleCalculatorTDDClass calc = new SimpleCalculatorTDDClass();

            //Act
            int result = calc.GetMultiply(7, 8);

            //Assert
            Assert.Equal(56, result);
        }

        [Fact]
        public void GetDivide_42_Div_6_Eq_7()
        {
            //Arrange 
            SimpleCalculatorTDDClass calc = new SimpleCalculatorTDDClass();

            //Act
            int result = calc.GetDivide(42, 6);

            //Assert
            Assert.Equal(7, result);
        }
    }
}

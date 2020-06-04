using CreditCompanyLibrary;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;

namespace CreditCompanyTests
{
    public class PaymentCalculatorTests
    {
        private readonly PaymentCalculator _calculator;

        private readonly List<Payment> _payments;

        public PaymentCalculatorTests()
        {
            _calculator = new PaymentCalculator();
            _payments = new List<Payment>();
            _payments.Add(new Payment(004, 200, Category.Entertainment, 0));
            _payments.Add(new Payment(004, 200, Category.Entertainment, 0));
            _payments.Add(new Payment(004, 200, Category.Entertainment, 1));

        }
        [Fact]
        public void ShouldReturnTrueIfPaymentIsFromLastMonth()
        {
            //arrange
            var _payment = new Payment(004, 200, Category.Entertainment, 0);
            //act
            var actualResult = _calculator.PaymentIsFromLastMonth(_payment);
            var expectedResult = true;
            //assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void ShouldCountPaymentsOfLastMonth()
        {
            // arrange
            //act
            var actualResult = _calculator.CountPaymentsOfLastMonth(_payments);
            var expectedResult = 400;
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldCountPaymentsOfCurentMonth()
        {
            // arrange
           
            //act
            var actualResult = _calculator.CountPaymentsOfCurrentMonth(_payments);
            var expectedResult = 200;
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldBeTrueIfLastMonthExpansesBigger()
        {
            //arrange
           
        }
    }
}

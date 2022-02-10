using AccountFormatLibrary;

using System;

using Xunit;

namespace TestInterestCalculation {

    public class UnitTest1 {

        [Theory]
        [InlineData(36, 36, 0.12, 100)]
        public void TestCalcIntByMonths(decimal interestAmount, int months, decimal interestRate, decimal balance) {
            Assert.Equal(interestAmount,
                FormatAccount.CalculateInterestByMonths(months, interestRate, balance));
        }
    }
}

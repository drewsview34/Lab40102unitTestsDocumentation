using System;
using Xunit;
using Lab40102unitTestsDocumentation;

namespace Lab40102xUnit
{
    public class RunTests
    {
        [Fact]
        // Tests to check if user can add money
        public void CanAddMoney()
        {
            Program.balance = 50;
            Program.AddMoney(45);
            Assert.Equal(95, Program.balance);
        }
        [Fact]
        // Tests to check if user can withdraw
        public void CanWithdraw()
        {
            Program.balance = 50;
            Program.WithdrawMethod(10);
            Assert.Equal(40, Program.balance);
        }
        [Fact]
        // Tests to check if user cannot withdraw
        public void CannotWithdraw()
        {
            Program.balance = 50;
            Program.AddMoney(-40);
            Assert.Equal(50, Program.balance);
        }
    }
}
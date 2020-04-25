using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void ThrowWhenUnsuportedOperation()
        {
            var sut = new Calculator();

            Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            
            var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            Assert.AreEqual("+", ex.Operation);
        }
    }
}

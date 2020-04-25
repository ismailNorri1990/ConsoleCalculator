using NUnit.Framework;

namespace ConsoleCalculator
{
    public class CalculatorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Calculate(1, 1, "+"), Throws.TypeOf<CalculationOperationNotSupportedException>().With.Property("Operation").EqualTo("+"));
            Assert.That(() => sut.Calculate(1, 1, "+"), Throws.InstanceOf<CalculationOperationNotSupportedException>());
            Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

            var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            Assert.That(ex.Operation, Is.EqualTo("+"));
        }
    }
}
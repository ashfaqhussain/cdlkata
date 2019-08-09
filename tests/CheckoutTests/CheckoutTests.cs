using NUnit.Framework;

namespace CheckoutTests
{
    public class CheckoutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetTotalPrice_ForItemA_ReturnsCorrectTotal()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("A");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.GreaterThan(-1));
        }
    }
}
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
        public void GetTotalPrice_ForItemA_Returns50()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("A");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void GetTotalPrice_ForTwoItemA_Returns100()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("A");
            sut.Scan("A");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void GetTotalPrice_ForThreeItemA_Returns130()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("A");
            sut.Scan("A");
            sut.Scan("A");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(130));
        }

        [Test]
        public void GetTotalPrice_ForFourItemA_Returns180()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("A");
            sut.Scan("A");
            sut.Scan("A");
            sut.Scan("A");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(180));
        }

    }
}
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

        [Test]
        public void GetTotalPrice_ForItemB_Returns30()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("B");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void GetTotalPrice_ForTwoItemB_Returns45()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("B");
            sut.Scan("B");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(45));
        }

        [Test]
        public void GetTotalPrice_ForThreeItemB_Returns75()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("B");
            sut.Scan("B");
            sut.Scan("B");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(75));
        }

        [Test]
        public void GetTotalPrice_ForOneOfEachItem_Returns115()
        {
            //Arrange
            var sut = new Checkout.Checkout();

            //Act
            sut.Scan("A");
            sut.Scan("B");
            sut.Scan("C");
            sut.Scan("D");
            var result = sut.GetTotalPrice();

            //Assert
            Assert.That(result, Is.EqualTo(115));
        }

    }
}
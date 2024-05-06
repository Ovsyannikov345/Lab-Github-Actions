namespace DiscountSystem.Test
{
    [TestFixture]
    public class DiscountCalculatorDataDrivenTests
    {
        private DiscountCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DiscountCalculator();
        }

        [Test]
        [TestCase(ClientType.Private, 9, 9000, 0.05, true)]
        [TestCase(ClientType.Private, 9, 19000, 0.1, true)]
        [TestCase(ClientType.Private, 9, 29000, 0.15, true)]
        [TestCase(ClientType.Private, 19, 9000, 0.1, true)]
        [TestCase(ClientType.Private, 19, 19000, 0.15, true)]
        [TestCase(ClientType.Private, 19, 29000, 0.15, true)]
        [TestCase(ClientType.Private, 29, 9000, 0.15, true)]
        [TestCase(ClientType.Private, 29, 19000, 0.15, true)]
        [TestCase(ClientType.Private, 29, 29000, 0.15, true)]
        [TestCase(ClientType.Corporate, 9, 9000, 0.05, false)]
        [TestCase(ClientType.Corporate, 9, 19000, 0.1, false)]
        [TestCase(ClientType.Corporate, 9, 29000, 0.15, false)]
        [TestCase(ClientType.Corporate, 19, 9000, 0.1, false)]
        [TestCase(ClientType.Corporate, 19, 19000, 0.15, false)]
        [TestCase(ClientType.Corporate, 19, 29000, 0.15, false)]
        [TestCase(ClientType.Corporate, 29, 9000, 0.15, false)]
        [TestCase(ClientType.Corporate, 29, 19000, 0.15, false)]
        [TestCase(ClientType.Corporate, 29, 29000, 0.15, false)]

        public void CalculateDiscount_ReturnsValidDiscountAndPoints(ClientType clientType, int itemsCount, int totalPrice, double expectedDiscount, bool expectedIsBonusPointsAwarded)
        {
            // Arrange
            Order order = new Order(clientType, itemsCount, totalPrice);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(expectedDiscount));
                Assert.That(discount.isBonusPointsAwarded, Is.EqualTo(expectedIsBonusPointsAwarded));
            });
        }
    }
}

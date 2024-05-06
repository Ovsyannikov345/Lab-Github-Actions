namespace DiscountSystem.Test
{
    [TestFixture]
    public class DiscountCalculatorTests
    {
        private DiscountCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DiscountCalculator();
        }

        [Test]
        public void CalculateDiscount_9Items9000PriceByPrivateClient_ReturnsSmallDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 9, 9000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.05));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_9Items19000PriceByPrivateClient_ReturnsMediumDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 9, 19000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.1));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_9Items29000PriceByPrivateClient_ReturnsLargeDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 9, 29000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_19Items9000PriceByPrivateClient_ReturnsMediumDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 19, 9000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.1));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_19Items19000PriceByPrivateClient_ReturnsLargeDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 19, 19000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_19Items29000PriceByPrivateClient_ReturnsLargeDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 19, 29000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_29Items9000PriceByPrivateClient_ReturnsLargeDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 29, 9000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_29Items19000PriceByPrivateClient_ReturnsLargeDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 29, 19000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_29Items29000PriceByPrivateClient_ReturnsLargeDiscountWithPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Private, 29, 29000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.True);
            });
        }

        [Test]
        public void CalculateDiscount_9Items9000PriceByCorporateClient_ReturnsSmallDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 9, 9000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.05));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_9Items19000PriceByCorporateClient_ReturnsMediumDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 9, 19000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.1));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_9Items29000PriceByCorporateClient_ReturnsLargeDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 9, 29000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_19Items9000PriceByCorporateClient_ReturnsMediumDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 19, 9000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.1));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_19Items19000PriceByCorporateClient_ReturnsLargeDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 19, 19000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_19Items29000PriceByCorporateClient_ReturnsLargeDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 19, 29000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_29Items9000PriceByCorporateClient_ReturnsLargeDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 29, 9000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_29Items19000PriceByCorporateClient_ReturnsLargeDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 29, 19000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }

        [Test]
        public void CalculateDiscount_29Items29000PriceByCorporateClient_ReturnsLargeDiscountWithoutPoints()
        {
            // Arrange
            Order order = new Order(ClientType.Corporate, 29, 29000);

            // Act
            Discount discount = _calculator.CalculateDiscount(order);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(discount.discount, Is.EqualTo(0.15));
                Assert.That(discount.isBonusPointsAwarded, Is.False);
            });
        }
    }
}
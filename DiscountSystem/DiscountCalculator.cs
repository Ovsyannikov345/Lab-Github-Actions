using System;

namespace DiscountSystem
{
    public class DiscountCalculator
    {
        public Discount CalculateDiscount(Order order)
        {
            if (order.ItemsCount < 1)
            {
                throw new ArgumentException("Invalid order items count", nameof(order));
            }

            if (order.TotalPrice < 0)
            {
                throw new ArgumentException("Invalid order total price", nameof(order));
            }

            int orderLevel = 0;

            orderLevel += order.ItemsCount switch
            {
                < 10 => 0,
                < 20 => 1,
                >= 20 => 2,
            };

            orderLevel += order.TotalPrice switch
            {
                < 10_000 => 0,
                <= 20_000 => 1,
                > 20_000 => 2,
            };

            bool isBonusPointsAwarded = order.ClientType == ClientType.Private;

            return orderLevel switch
            {
                0 => new Discount(0.05, isBonusPointsAwarded),
                1 => new Discount(0.1, isBonusPointsAwarded),
                _ => new Discount(0.15, isBonusPointsAwarded),
            };
        }
    }
}

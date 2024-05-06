namespace DiscountSystem
{
    public class Discount
    {
        public readonly double discount;

        public readonly bool isBonusPointsAwarded;

        public Discount(double discount, bool isBonusPointsAwarded)
        {
            this.discount = discount;
            this.isBonusPointsAwarded = isBonusPointsAwarded;
        }
    }
}

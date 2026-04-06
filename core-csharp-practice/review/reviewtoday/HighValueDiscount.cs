class HighValueDiscount : IDiscountRule
{
    public int Priority => 2;

    public double ApplyDiscount(Cart cart, double currentAmount)
    {
        if (currentAmount > 1000)
            return currentAmount - 100;

        return currentAmount;
    }
}

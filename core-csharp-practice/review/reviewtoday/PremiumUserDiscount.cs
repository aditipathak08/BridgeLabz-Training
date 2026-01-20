class PremiumUserDiscount : IDiscountRule
{
    public int Priority => 1;

    public double ApplyDiscount(Cart cart, double currentAmount)
    {
        if (cart.IsPremiumUser)
            return currentAmount * 0.90; 
        return currentAmount;
    }
}

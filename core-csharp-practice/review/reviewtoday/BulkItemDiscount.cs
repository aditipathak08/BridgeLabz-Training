class BulkItemDiscount : IDiscountRule
{
    public int Priority => 3;

    public double ApplyDiscount(Cart cart, double currentAmount)
    {
        if (cart.ItemCount >= 5)
            return currentAmount - 50;

        return currentAmount;
    }
}

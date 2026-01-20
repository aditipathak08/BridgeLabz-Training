class DiscountEngine
{
    private IDiscountRule[] rules;

    public DiscountEngine(IDiscountRule[] rules)
    {
        this.rules = rules.OrderBy(r => r.Priority).ToArray();
    }

    public double CalculateFinalAmount(Cart cart)
    {
        double amount = cart.TotalAmount;

        foreach (var rule in rules)
        {
            amount = rule.ApplyDiscount(cart, amount);
        }

        return amount;
    }
}

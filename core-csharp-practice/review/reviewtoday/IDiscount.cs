interface IDiscountRule
{
    int Priority { get; }
    double ApplyDiscount(Cart cart, double currentAmount);
}
class Program
{
    static void Main()
    {
        Cart cart = new Cart
        {
            TotalAmount = 12500,
            IsPremiumUser = true,
            ItemCount = 6
        };

        IDiscountRule[] rules =
        {
            new PremiumUserDiscount(),
            new HighValueDiscount(),
            new BulkItemDiscount()
        };

        DiscountEngine engine = new DiscountEngine(rules);

        double finalAmount = engine.CalculateFinalAmount(cart);

        Console.WriteLine("Final Payable Amount: " + finalAmount);
    }
}

class Letter : DeliveryItem
{
    public Letter(double mass) : base(mass) {}

    public override double CalculateCost() => 15 + (Mass * 10);
}
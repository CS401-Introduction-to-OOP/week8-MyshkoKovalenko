class Parcel : DeliveryItem
{
    public string Dimensions { get; }

    public Parcel(double mass, string dimensions) : base(mass)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost() => 50 + (Mass * 25);

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimension: {Dimensions}");
    }
}
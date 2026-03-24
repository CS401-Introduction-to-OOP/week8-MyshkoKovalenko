abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    
    public double Mass { get; }

    public DeliveryItem(double mass)
    {
        Random rnd = new Random();
        TrackingNumber = rnd.GetHexString(6);
        Mass = mass;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"{TrackingNumber} - {Mass} kg");
    }
}
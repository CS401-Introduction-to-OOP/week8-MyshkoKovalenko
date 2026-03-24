class CargoContainer<T> where T : DeliveryItem
{
    List<T> _items;

    public CargoContainer()
    {
        _items = new List<T>();
    }

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double cost = 0;
        foreach(T i in _items)
            cost += i.CalculateCost();
        return cost;
    }
}
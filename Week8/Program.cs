Letter l1 = new Letter(0.010);
Letter l2 = new Letter(0.015);
Parcel p1 = new Parcel(67, "0.5x1.73x0.5");
Parcel p2 = new Parcel(5000000, "60x7x20");

l1.PrintInfo();
p1.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(l1);
myCargo.AddItem(l2);
myCargo.AddItem(p1);
myCargo.AddItem(p2);

Console.WriteLine(myCargo.GetTotalCost());
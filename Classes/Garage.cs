class Garage
{
	public int parkingSpots;
	public string garageAddress;
	public List<Vehicle> vehicles = new List<Vehicle>();

	public Garage(int spots = 0, string address = "")
	{
		parkingSpots = spots;
		garageAddress = address;
	}

	public void park(string regNr)
	{
		var vehicle = new Vehicle(regNr);
		vehicles.Add(vehicle);
	}

}
namespace GarageApp;
using Spectre.Console;
class Program
{
	static void Main(string[] args)
	{
		var garage = new Garage(20, "Test");
		AnsiConsole.MarkupLine("[underline blue] Welcome to the Garage! [/]");
		var freeSpots = (garage.parkingSpots - garage.vehicles.Count);
		AnsiConsole.MarkupLine("This garage has 20 parking spots, currently there is [underline green]{0}[/] spots available", freeSpots);
		var appRunning = true;
		while (appRunning)
		{
			var choice = AnsiConsole.Prompt(
				new SelectionPrompt<string>()
				.Title("Select action")
				.PageSize(10)
				.AddChoices(new[] {
					"Park", "List available",  "Quit"
				}));
			switch (choice)
			{
				case "Park":
					var regNr = AnsiConsole.Ask<string>("Enter [green]registration number:[/]");
					garage.park(regNr);
					AnsiConsole.MarkupLine("Successfully parked: [green]{0}[/]", regNr);
					break;
				case "List available":
					freeSpots = (garage.parkingSpots - garage.vehicles.Count);
					AnsiConsole.MarkupLine("There are [green]{0}[/] spots available", freeSpots);
					break;
				case "Quit":
					appRunning = false;
					break;
				default:
					break;
			}
		}
	}
}

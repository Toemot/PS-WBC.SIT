// See https://aka.ms/new-console-template for more information
using WBC.DA;

Console.WriteLine("Hello, Coffee Shop!");
Console.WriteLine("Write 'help' to list the available commands, write 'quit' to exit the application.");

var coffeeShopDP = new CSDataProvider();

while (true)
{
    var line = Console.ReadLine();

    if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    var coffeeShops = coffeeShopDP.LoadCoffeeShop();

    if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("> Available coffee shop commands: ");
        foreach (var coffeeShop in coffeeShops)
        {
            Console.WriteLine($"> " + coffeeShop.Location);
        }
    }
}

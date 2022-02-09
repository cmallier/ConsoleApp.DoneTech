using ConsoleApp.DoneTech;
using ConsoleApp.DoneTech.Printers;

internal class FizzBuzzApp
{
    // Fields
    private readonly IPrintable _printer;
    private readonly FizzBuzzConfigurator _config;


    // Constructor
    public FizzBuzzApp(IPrintable printer, FizzBuzzConfigurator config)
    {
        _printer = printer;
        _config = config;
    }

    // Public methods
    public void Print(IEnumerable<int> integers)
    {
        foreach (int integer in integers)
        {        
            string? output = _config.GetOutput(integer);
            
            _printer.Print(integer, output);
        }
    }
}

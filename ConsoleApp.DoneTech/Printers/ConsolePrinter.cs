using ConsoleApp.DoneTech.Printers;

internal class ConsolePrinter : IPrintable
{
    public void Print( int number, string? word )
    {
        if (word is not null)
        {
            Console.WriteLine($"{number} - {word}");
        }
        else
        {
            Console.WriteLine($"{number}");
        }
    }
}

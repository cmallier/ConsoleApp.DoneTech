using ConsoleApp.DoneTech;
using ConsoleApp.DoneTech.Enums;

internal class FizzBuzzRule
{
    private readonly string _outputName;
    private readonly int[] _multiples;
    private readonly FizzBuzzOperation _operation;


    // Constructor
    public FizzBuzzRule(int multiple, string outputName)
    {
        _multiples = new int[1];
        _multiples[0] = multiple;
        _outputName = outputName;
        _operation = FizzBuzzOperation.And;
    }

    public FizzBuzzRule(int[] multiples, string outputName, FizzBuzzOperation operation)
    {
        _multiples = multiples;
        _outputName = outputName;
        _operation = operation;
    }

    // Properties
    public string OutputName => _outputName;
    public FizzBuzzOperation Operation => _operation;
    public int[] Multiples => _multiples;
}

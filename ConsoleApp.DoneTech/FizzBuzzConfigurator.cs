using ConsoleApp.DoneTech.Enums;

internal class FizzBuzzConfigurator
{
    // Properties
    private readonly List<FizzBuzzRule> _rules;
    private readonly FizzBuzzPattern _pattern;


    // Constructor
    public FizzBuzzConfigurator(FizzBuzzPattern pattern)
    {
        _rules = new List<FizzBuzzRule>();
        _pattern = pattern;
    }

    public void AddRule( FizzBuzzRule rule )
    {
        _rules.Add(rule);
    }

    // Public methods
    public string? GetOutput(int number)
    {
        List<FizzBuzzRule> rules = GetOrderedRules();

        foreach (FizzBuzzRule rule in rules)
        {
            if (rule.Operation == FizzBuzzOperation.And)
            {
                if (rule.Multiples.All(x => number % x == 0))
                {
                    return rule.OutputName;
                }
            }
            else if (rule.Operation == FizzBuzzOperation.Or)
            {
                if (rule.Multiples.Any(x => number % x == 0))
                {
                    return rule.OutputName;
                }
            }
        }

        return null;
    }


    // Private methods
    private List<FizzBuzzRule> GetOrderedRules()
    {
        switch (_pattern)
        {
            case FizzBuzzPattern.FirstMatch:
                return _rules;
            case FizzBuzzPattern.MostSpecific:
                return _rules.OrderByDescending(x => x.Multiples.Length).ToList();
        }
        
        throw new NotImplementedException($"{_pattern} (FizzBuzzPattern)");
    }
}
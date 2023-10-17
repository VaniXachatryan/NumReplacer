namespace NumReplacer.Strategy;

public class FizzBaseStrategy : BaseStrategy
{
    public FizzBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        if (value != null && value % Constants.FIZZ == 0 && IsExistValue(value))
            elements = elements.Append(nameof(Constants.FIZZ)).ToArray();
        
        return elements;
    }
}
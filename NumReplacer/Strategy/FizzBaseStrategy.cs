namespace NumReplacer.Strategy;

public class FizzBaseStrategy : BaseStrategy
{
    public FizzBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        int index = Array.IndexOf(Elements, value);
        if (value != null && value % Constants.FIZZ == 0 && index != -1)
            elements = elements.Append(nameof(Constants.FIZZ)).ToArray();
        
        return elements;
    }
}
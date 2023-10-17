namespace NumReplacer.Strategy;

public class BuzzBaseStrategy : BaseStrategy
{
    public BuzzBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        if (value != null && value % Constants.BUZZ == 0 && IsExistValue(value))
            elements = elements.Append(nameof(Constants.BUZZ)).ToArray();
        
        return elements;
    }
}
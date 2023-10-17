namespace NumReplacer.Strategy;

public class GuzzBaseStrategy : BaseStrategy
{
    public GuzzBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        if (value != null && value % Constants.GUZZ == 0 && IsExistValue(value))
            elements = elements.Append(nameof(Constants.GUZZ)).ToArray();
        
        return elements;
    }
}
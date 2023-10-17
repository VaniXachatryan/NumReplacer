namespace NumReplacer.Strategy;

public class GuzzBaseStrategy : BaseStrategy
{
    private List<string> result = new();

    public GuzzBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        int index = Array.IndexOf(Elements, value);
        if (value != null && value % Constants.GUZZ == 0 && index != -1)
            elements = elements.Append(nameof(Constants.GUZZ)).ToArray();
        
        return elements;
    }
}
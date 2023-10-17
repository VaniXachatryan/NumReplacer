namespace NumReplacer.Strategy;

public class BuzzStrategy : Strategy
{
    public BuzzStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        int index = Array.IndexOf(Elements, value);
        if (value != null && value % Constants.BUZZ == 0 && index != -1)
            elements = elements.Append(nameof(Constants.BUZZ)).ToArray();
        
        return elements;
    }
}
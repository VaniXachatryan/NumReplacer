namespace NumReplacer.Strategy;

public class MuzzBaseStrategy : BaseStrategy
{
    public MuzzBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        if (value != null && value % Constants.MUZZ == 0 && IsExistValue(value))
            elements = elements.Append(nameof(Constants.MUZZ)).ToArray();
        
        return elements;
    }
}
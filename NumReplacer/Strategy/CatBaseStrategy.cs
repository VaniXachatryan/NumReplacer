namespace NumReplacer.Strategy;

public class CatBaseStrategy : BaseStrategy
{
    public CatBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        if (value != null && value % Constants.CAT == 0 && IsExistValue(value))
            elements = new string[] { "cat" };
        
        return elements;

    }
}
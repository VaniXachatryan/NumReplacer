namespace NumReplacer.Strategy;

public class DogBaseStrategy : BaseStrategy
{
    public DogBaseStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        if (value != null && value % Constants.DOG == 0 && IsExistValue(value))
            elements = new string[] { "dog" };
        
        return elements;

    }
}
namespace NumReplacer.Strategy;

public class DogStrategy : Strategy
{
    public DogStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        int indexDog = Array.IndexOf(Elements, value);
        if (value != null && value % Constants.DOG == 0 && indexDog != -1)
            elements = new string[] { "dog" };
        
        return elements;

    }
}
namespace NumReplacer.Strategy;

public class CatStrategy : Strategy
{
    public CatStrategy(List<int> elements) : base(elements)
    {
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        int indexCat = Array.IndexOf(Elements, value);
        if (value != null && value % Constants.CAT == 0 && indexCat != -1)
            elements = new string[] { "cat" };
        
        return elements;

    }
}
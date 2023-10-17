namespace NumReplacer.Strategy;

public class GoodBoyStrategy : Strategy
{
    private Strategy _dogStrategy;
    private Strategy _catStrategy;
    
    public GoodBoyStrategy(List<int> elements) : base(elements)
    {
        _dogStrategy = new DogStrategy(elements);
        _catStrategy = new CatStrategy(elements);
    }
    
    public override string[] Replace(string[] elements, int? value)
    {
        if (value != null && value % Constants.CAT == 0 
                          && value % Constants.DOG == 0
                          && value % Constants.FIZZ == 0
                          && value % Constants.BUZZ == 0
                          && value % Constants.MUZZ == 0
                          && value % Constants.GUZZ == 0)
        {

            int indexDog = Array.IndexOf(Elements.ToArray(), (int)value);
            if (value % indexDog != -1)
                elements = elements.Prepend("good-boy").ToArray();
            
        } else if (value != null && value % Constants.CAT == 0 && value % Constants.DOG == 0)
            elements = new string[] { "good-boy" };

        return elements;
    }
}
namespace NumReplacer.Strategy;

public class GoodBoyBaseStrategy : BaseStrategy
{
    private BaseStrategy _dogBaseStrategy;
    private BaseStrategy _catBaseStrategy;
    
    public GoodBoyBaseStrategy(List<int> elements) : base(elements)
    {
        _dogBaseStrategy = new DogBaseStrategy(elements);
        _catBaseStrategy = new CatBaseStrategy(elements);
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
            if (IsExistValue(value))
                elements = elements.Prepend("good-boy").ToArray();
        } else if (value != null && value % Constants.CAT == 0 && value % Constants.DOG == 0)
            elements = new string[] { "good-boy" };

        return elements;
    }
}
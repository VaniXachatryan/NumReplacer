namespace NumReplacer.Strategy;

public abstract class BaseStrategy
{
    public int[] Elements;

    protected BaseStrategy(List<int> elements)
    {
        Elements = elements.ToArray();
    }

    public abstract string[] Replace(string[] elements, int? value);
}
namespace NumReplacer.Strategy;

public abstract class Strategy
{
    public int[] Elements;

    protected Strategy(List<int> elements)
    {
        Elements = elements.ToArray();
    }

    public abstract string[] Replace(string[] elements, int? value);
}
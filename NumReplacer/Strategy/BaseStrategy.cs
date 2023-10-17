namespace NumReplacer.Strategy;

public abstract class BaseStrategy
{
    public readonly int[] Elements;

    protected BaseStrategy(List<int> elements)
    {
        Elements = elements.ToArray();
    }

    public abstract string[] Replace(string[] elements, int? value);

    protected bool IsExistValue(int? value)
        => Elements.Any(e => e == value);
}
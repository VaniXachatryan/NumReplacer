namespace NumReplacer.Strategy;

public class ReplaceStrategyContext
{
    private BaseStrategy _baseStrategy;
    private List<string> _result;

    public ReplaceStrategyContext()
    {
    }

    public void SetStrategy(BaseStrategy baseStrategy)
        => _baseStrategy = baseStrategy;

    public string[] Replace(List<string> elements)
    {
        _result = new List<string>();
        
        int indexElement = 0;
        foreach (var element in elements)
        {
            int value = _baseStrategy.Elements[indexElement];
            string[] replaced = _baseStrategy.Replace(new string[] { element }, value);
            if (replaced.Length > 1)
            {
                int indexValue = Array.IndexOf(replaced, value.ToString());
                if (indexValue != -1) 
                    replaced[indexValue] = string.Empty;
            }
            
            _result.Add(string.Join("-", replaced.Select(r => r.ToLower()).Where(r => r != String.Empty).ToArray()));
            indexElement++;
        }

        return _result.ToArray();
    }
}
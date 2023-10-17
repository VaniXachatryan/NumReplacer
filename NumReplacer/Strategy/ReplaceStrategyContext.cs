namespace NumReplacer.Strategy;

public class ReplaceStrategyContext
{
    private Strategy _strategy;
    private List<string> _result;

    public ReplaceStrategyContext()
    {
    }

    public void SetStrategy(Strategy strategy)
        => _strategy = strategy;

    public string[] Replace(List<string> elements)
    {
        _result = new List<string>();
        
        int indexElement = 0;
        foreach (var element in elements)
        {
            int value = _strategy.Elements[indexElement];
            string[] replaced = _strategy.Replace(new string[] { element }, value);
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
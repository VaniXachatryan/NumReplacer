using NumReplacer.Strategy;

namespace NumReplacer.Interfaces;

public interface IStrategyContext
{
    void SetStrategy(BaseStrategy baseStrategy);
    string[] Execute(List<string> elements);
}
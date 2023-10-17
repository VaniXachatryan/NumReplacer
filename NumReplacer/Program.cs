using NumReplacer.Interfaces;
using NumReplacer.Strategy;

List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};

string[] result = elements.Select(e => e.ToString()).ToArray();
IStrategyContext replaceContext = new ReplaceStrategyContext();

List<BaseStrategy> strategies = new List<BaseStrategy>();

// 1 Задание
Console.WriteLine("1 Задание:");
strategies.Add(new FizzBaseStrategy(elements));
strategies.Add(new BuzzBaseStrategy(elements));
foreach (var strategy in strategies)
{
    replaceContext.SetStrategy(strategy);
    result = replaceContext.Execute(result.ToList());
}
Console.WriteLine("{0}", string.Join(", ", result));

// 2 Задание
Console.WriteLine("2 Задание:");
strategies.Add(new MuzzBaseStrategy(elements));
strategies.Add(new GuzzBaseStrategy(elements));
foreach (var strategy in strategies)
{
    replaceContext.SetStrategy(strategy);
    result = replaceContext.Execute(result.ToList());
}
Console.WriteLine("{0}", string.Join(", ", result));

// 3 Задание*
Console.WriteLine("3 Задание:");
strategies.Add(new DogBaseStrategy(elements));
strategies.Add(new CatBaseStrategy(elements));
strategies.Add(new GoodBoyBaseStrategy(elements));
foreach (var strategy in strategies)
{
    replaceContext.SetStrategy(strategy);
    result = replaceContext.Execute(result.ToList());
}

Console.WriteLine("{0}", string.Join(", ", result));


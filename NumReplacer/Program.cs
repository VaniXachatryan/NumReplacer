using NumReplacer.Strategy;

List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};

string[] result = elements.Select(e => e.ToString()).ToArray();
ReplaceStrategyContext replaceContext = new ReplaceStrategyContext();

List<Strategy> strategies = new List<Strategy>();

// 1 Задание
strategies.Add(new FizzStrategy(elements));
strategies.Add(new BuzzStrategy(elements));

// 2 Задание
strategies.Add(new MuzzStrategy(elements));
strategies.Add(new GuzzStrategy(elements));

// 3 Задание*
strategies.Add(new DogStrategy(elements));
strategies.Add(new CatStrategy(elements));
strategies.Add(new GoodBoyStrategy(elements));

foreach (var strategy in strategies)
{
    replaceContext.SetStrategy(strategy);
    result = replaceContext.Replace(result.ToList());
}

Console.WriteLine("{0}", string.Join(", ", result));


using NumReplacer.Strategy;
using NUnit.Framework;

namespace NumReplacer.Tests;

public class ReplaceTest
{
    private ReplaceStrategyContext _context;
    
    [SetUp]
    public void Setup()
    {
        _context = new ReplaceStrategyContext();
    }

    [Test]
    public void TestFizzBuzz()
    {
        List<BaseStrategy> strategies = new List<BaseStrategy>();
        List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
        string[] result = elements.Select(e => e.ToString()).ToArray();
        
        strategies.Add(new FizzBaseStrategy(elements));
        strategies.Add(new BuzzBaseStrategy(elements));
        
        foreach (var strategy in strategies)
        {
            _context.SetStrategy(strategy);
            result = _context.Replace(result.ToList());
        }

        string[] expect = "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz".Split(", ");
        Assert.AreEqual(expect, result);
    }
    
    [Test]
    public void TestGuzzMuzz()
    {
        List<BaseStrategy> strategies = new List<BaseStrategy>();
        List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};
        string[] result = elements.Select(e => e.ToString()).ToArray();
        
        strategies.Add(new FizzBaseStrategy(elements));
        strategies.Add(new BuzzBaseStrategy(elements));
        strategies.Add(new MuzzBaseStrategy(elements));
        strategies.Add(new GuzzBaseStrategy(elements));
        
        foreach (var strategy in strategies)
        {
            _context.SetStrategy(strategy);
            result = _context.Replace(result.ToList());
        }

        string[] expect = "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz"
            .Split(", ");
        
        Assert.AreEqual(expect, result);
    }
    
    [Test]
    public void TestGoodDog()
    {
        List<BaseStrategy> strategies = new List<BaseStrategy>();

        List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};
        string[] result = elements.Select(e => e.ToString()).ToArray();
        
        strategies.Add(new FizzBaseStrategy(elements));
        strategies.Add(new BuzzBaseStrategy(elements));
        strategies.Add(new MuzzBaseStrategy(elements));
        strategies.Add(new GuzzBaseStrategy(elements));
        strategies.Add(new CatBaseStrategy(elements));
        strategies.Add(new DogBaseStrategy(elements));
        strategies.Add(new GoodBoyBaseStrategy(elements));
        
        foreach (var strategy in strategies)
        {
            _context.SetStrategy(strategy);
            result = _context.Replace(result.ToList());
        }

        string[] expect = "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, dog, 13, guzz, good-boy, good-boy, good-boy, good-boy-dog"
            .Split(", ");
        
        Assert.AreEqual(expect, result);
    }
}
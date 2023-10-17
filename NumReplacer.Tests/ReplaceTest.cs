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
        List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
        string[] result = elements.Select(e => e.ToString()).ToArray();
        
        _context.SetStrategy(new FizzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new BuzzStrategy(elements));
        result = _context.Replace(result.ToList());

        string[] expect = "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz".Split(", ");
        Assert.AreEqual(expect, result);
    }
    
    [Test]
    public void TestGuzzMuzz()
    {
        List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};
        string[] result = elements.Select(e => e.ToString()).ToArray();
        
        _context.SetStrategy(new FizzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new BuzzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new MuzzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new GuzzStrategy(elements));
        result = _context.Replace(result.ToList());

        string[] expect = "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz"
            .Split(", ");
        
        Assert.AreEqual(expect, result);
    }
    
    [Test]
    public void TestGoodDog()
    {
        List<int> elements = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};
        string[] result = elements.Select(e => e.ToString()).ToArray();
        
        _context.SetStrategy(new FizzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new BuzzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new MuzzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new GuzzStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new CatStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new DogStrategy(elements));
        result = _context.Replace(result.ToList());
        
        _context.SetStrategy(new GoodBoyStrategy(elements));
        result = _context.Replace(result.ToList());

        string[] expect = "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, dog, 13, guzz, good-boy, good-boy, good-boy, good-boy-dog"
            .Split(", ");
        
        Assert.AreEqual(expect, result);
    }
}
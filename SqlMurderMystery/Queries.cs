using Xunit.Abstractions;

namespace SqlMurderMystery;

public class Queries
{
    private readonly ITestOutputHelper outPutter;
    private AppContext ctx = new();

    public Queries(ITestOutputHelper outPutter)
    {
        this.outPutter = outPutter;
    }

    [Fact]
    public void Print10People()
    {
        var persons = ctx.People.Take(10).ToList();
        outPutter.PrintList(persons);
    }
}
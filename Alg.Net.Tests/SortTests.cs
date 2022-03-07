using System.Linq;
using Xunit;

namespace Alg.Net.Tests;

public class SortTests
{
    private readonly int[] _a = { 2, 5, 3, 1, 4 };
    private readonly int[] _e = { 1, 2, 3, 4, 5 };

    [Fact]
    public void Insertion_Sorts()
    {
        var r = Sort.Insertion(_a);
        Assert.Equal(_e, r);
    }

    [Fact]
    public void Selection_Sorts()
    {
        var r = Sort.Selection(_a);
        Assert.Equal(_e, r);
    }
}

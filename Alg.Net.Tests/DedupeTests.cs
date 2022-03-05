using Xunit;

namespace Alg.Net.Tests;

public class DedupeTests
{
    private readonly int[] _simple = new int[] { 1, 2, 3, 3, 4, 5 };
    private readonly int[] _simpleExpected = new int[] { 1, 2, 3, 4, 5 };

    [Fact]
    public void Brute_Dedupes()
    {
        var result = Dedupe.Brute(_simple);

        var expected = _simpleExpected;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Hash_Dedupes()
    {
        var result = Dedupe.Hash(_simple);

        var expected = _simpleExpected;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sort_Dedupes()
    {
        var result = Dedupe.Sort(_simple);

        var expected = _simpleExpected;
        Assert.Equal(expected, result);
    }

    private readonly int[] _trailing = new int[] { 1, 2, 3, 4, 5, 5 };
    private readonly int[] _trailingExpected = new int[] { 1, 2, 3, 4, 5 };

    [Fact]
    public void Brute_DedupesTrailing()
    {
        var result = Dedupe.Brute(_trailing);

        var expected = _trailingExpected;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Hash_DedupesTrailing()
    {
        var result = Dedupe.Hash(_trailing);

        var expected = _trailingExpected;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sort_DedupesTrailing()
    {
        var result = Dedupe.Sort(_trailing);

        var expected = _trailingExpected;
        Assert.Equal(expected, result);
    }
}

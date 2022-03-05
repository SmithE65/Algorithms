// See https://aka.ms/new-console-template for more information
using Alg.Net;
using Alg.Net.Console;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

List<RunResult> results = new();

for (int i = 1000; i < 10_000; i += 1000)
{
    TestRun(i);
}

for (int i = 10000; i < 1_000_000; i += 10_000)
{
    TestRun(i);
}

{
    using var sw = new StreamWriter("results.csv");
    sw.WriteLine(@"""NumItems"",""BruteMs"",""HashMs"",""SortMs""");
    results.ForEach(r => sw.WriteLine($"{r.NumItems},{r.BruteMs},{r.HashMs},{r.SortMs}"));
}

static T Time<T>(Func<T> a, out long elapsed)
{
    var sw = new Stopwatch();
    sw.Start();
    var r = a();
    sw.Stop();
    elapsed = sw.ElapsedMilliseconds;
    return r;
}

int[] CreateRandom(int n)
{
    var a = new int[n];

    Time(() =>
    {
        var r = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = r.Next(int.MinValue, int.MaxValue);
        }
        return false;
    }, out var elapsed);
    Console.WriteLine($"Created array of {n} items in {elapsed}ms");

    return a;
}

void TestRun(int numItems)
{
    Console.WriteLine($"Test run for {numItems} items");
    var a = CreateRandom(numItems);
    _ = Time(() => Dedupe.Brute(a), out var b);
    Console.WriteLine($"Brute ran in {b}ms");
    _ = Time(() => Dedupe.Hash(a), out var h);
    Console.WriteLine($"Hash ran in {h}ms");
    _ = Time(() => Dedupe.Sort(a), out var s);
    Console.WriteLine($"Sort ran in {s}ms");
    results.Add(new RunResult { NumItems = numItems, BruteMs = b, HashMs = h, SortMs = s });
}

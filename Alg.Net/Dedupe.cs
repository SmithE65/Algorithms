namespace Alg.Net;

public static class Dedupe
{
    public static int[] Brute(int[] a)
    {
        var deduped = new List<int>(a.Length);
        foreach(var i in a)
        {
            if (!deduped.Contains(i))
            {
                deduped.Add(i);
            }
        }

        return deduped.ToArray();
    }

    public static int[] Hash(int[] a)
    {
        var h = new HashSet<int>(a);
        return h.ToArray();
    }

    public static int[] Sort(int[] a)
    {
        Array.Sort(a);
        var result = new List<int>(a.Length);
        if (a.Length > 0)
        {
            result.Add(a[0]);
        }
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i-1] != a[i])
            {
                result.Add(a[i]);
            }
        }
        return result.ToArray();
    }
}

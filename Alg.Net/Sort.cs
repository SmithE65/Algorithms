namespace Alg.Net;

public static class Sort
{
    public static T[] Insertion<T>(T[] array) where T : IComparable<T>
    {
        ArgumentNullException.ThrowIfNull(array);
        var a = array.ToArray();

        if (a.Length < 2)
        {
            return a;
        }

        for (int i = 1; i < a.Length; i++)
        {
            for (int j = i; j > 0 && a[j - 1].CompareTo(a[j]) > 0; j--)
            {
                Swap(ref a[j - 1], ref a[j]);
            }
        }

        return a;
    }

    public static T[] Selection<T>(T[] array) where T : IComparable<T>
    {
        ArgumentNullException.ThrowIfNull(array);
        var a = array.ToArray();

        if (a.Length < 2)
        {
            return a;
        }

        for (int i = 0; i < a.Length - 1; i++)
        {
            var idxMin = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[idxMin].CompareTo(a[j]) > 0)
                {
                    idxMin = j;
                }
            }

            if (idxMin != i)
            {
                Swap(ref a[i], ref a[idxMin]);
            }
        }

        return a;
    }

    //public static T[] Merge<T>(T[] array) where T : IComparable<T>
    //{
    //    ArgumentNullException.ThrowIfNull(array);
    //    var a = array.ToArray();

    //    if (a.Length < 2)
    //    {
    //        return a;
    //    }
    //    var (f, l) = Split(a);
    //    f = Merge(f);
    //    l = Merge(l);


        
    //    (T[] First, T[] Second) Split(T[] input)
    //    {
    //        var l = input.Length;
    //        var f = input.Take(l / 2).ToArray();
    //        var s = input.Skip(l / 2).ToArray();
    //        return (f, s);
    //    }
    //}

    private static void Swap<T>(ref T a, ref T b)
    {
        (b, a) = (a, b);
    }
}

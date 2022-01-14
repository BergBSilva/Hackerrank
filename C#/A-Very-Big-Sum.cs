public static long aVeryBigSum(List<long> ar)
    {
        var r = 0L;
        foreach(long result in ar)
        {
            r += result;
        }
        return r;

    }
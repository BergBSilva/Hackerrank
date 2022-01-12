public static int simpleArraySum(List<int> ar)
    {
        var arraySum = 0;
        foreach(int value in ar)
        {
            arraySum += value;
        }
        return arraySum;
    }
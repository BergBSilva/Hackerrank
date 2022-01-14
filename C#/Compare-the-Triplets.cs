public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var pointA = 0;
        var pointB = 0;
        
        var res = a.Zip(b, (n, n2) => new { Number1 = n, Number2 = n2 });
        foreach(var resul in res)
         {
            if(resul.Number1 > resul.Number2)
            {
                pointA += 1;             
            }
            else if(resul.Number1 < resul.Number2)
            {
                pointB += 1;
            }
            else{}
         }
         
        List<int> m = new List<int>();
        m.Add(pointA);
        m.Add(pointB);
        return m;

    }
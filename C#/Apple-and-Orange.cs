public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {        
        int quantidadeMaca = 0;
        int quantidadeLaranja = 0;
        
        foreach(var app in apples)
        {
            int sum = a;
            sum += app;            
            if(sum >= s && sum <= t)
            {
                quantidadeMaca +=1;
            }
        }
        foreach(var ora in oranges)
        {
            int sum = b;
            sum += ora;            
            if(sum >= s && sum <= t)
            {
                quantidadeLaranja +=1;
            }
        }
        
        Console.WriteLine(quantidadeMaca);
        Console.WriteLine(quantidadeLaranja);        
        
    }

public static int diagonalDifference(List<List<int>> arr)
    {
        var mainDiagonal = 0;
        var secondaryDiagonal = 0;
        var diference = 0;
        
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            { 
                
                if (i==j)
                {
                    mainDiagonal += arr[i][j];
                    if((i + j) == (arr.Count - 1))
                    {
                        secondaryDiagonal += arr[i][j];
                    }
                }
                else if((i + j) == (arr.Count - 1))
                {
                    secondaryDiagonal += arr[i][j];
                }
                else{}
            }            
            
        }
        diference = Math.Abs(mainDiagonal - secondaryDiagonal);
        return diference;    
    }
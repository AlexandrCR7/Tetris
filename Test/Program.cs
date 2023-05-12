int[,] Array = new int[10, 10];

    int x = 0;
    int y = 3;
    Array[x, y] = 1;
    int a = 0;
    int b = 4;
    Array[a, b] = 1;
    int q = 0;
    int w = 5;
    Array[q, w] = 1;
    int e = 1;
    int r = 4;
    Array[e, r] = 1;

void FillZeroArray(int[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            if(numbers[i, j] == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else Console.ForegroundColor = ConsoleColor.White;
            System.Console.Write($"{numbers[i, j]} ");
        }
        System.Console.WriteLine();
    }  
} 



void ChangePlace(int[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            if(numbers[i, j] == 1)
            {
                numbers[i, j] = 0;
            }
        }
    }
    
}

void ChangeArray(int[,] numbers)
{
    Array[x + 1, y - 1] = 1;
    Array[a + 1, b - 1] = 1;
    Array[q + 1, w - 1] = 1;
    Array[e + 1, r - 1] = 1;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]} ");
        }
        System.Console.WriteLine();
    }

}



FillZeroArray(Array);
System.Console.WriteLine();
ChangePlace(Array);
System.Console.WriteLine();
ChangeArray(Array);
System.Console.WriteLine();

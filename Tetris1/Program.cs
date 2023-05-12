// План работы: 
// 1. Создать массив заполненный нулями
// 2. Создать фигуры: квадрат, палка вертикальная, фак
// 3. Описать с помощью рандомного числа, какая фигура будет выпадать следующая
// 4. Описать функции, которые описывали бы движение данных фигур
//    - Где появляются фигуры
//    - Какие кнопки отвечают за движение фигуры
//    - При каких обстоятельствах заканчивается движение фигуры
//    - При каких обстоятельствах фигура не может выйти за рамки массива

// Если выпадает 1 то печтатаем T
// Если выпадает 2 то печатаем О



void Tfigure(int[,] numbers)
{
    int x = 0;
    int y = 3;
    numbers[x, y] = 1;
    int a = 0;
    int b = 4;
    numbers[a, b] = 1;
    int q = 0;
    int w = 5;
    numbers[q, w] = 1;
    int e = 1;
    int r = 4;
    numbers[e, r] = 1;
}


void Ofigure(int[,] numbers)
{
    numbers[0, 4] = 1;
    numbers[0, 5] = 1;
    numbers[1, 4] = 1;
    numbers[1, 5] = 1;
}

void Ifigure(int[,] numbers)
{
    numbers[0, 4] = 1;
    numbers[1, 4] = 1;
    numbers[2, 4] = 1;
    numbers[3, 4] = 1;
}


void Lfigure(int[,] numbers)
{
    numbers[0, 4] = 1;
    numbers[1, 4] = 1;
    numbers[2, 4] = 1;
    numbers[2, 5] = 1;
}

void FillZeroArray(int[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(0); j++)
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

int[,] Array = new int[10, 10];

void PrintFigureArray()
{
    string x = new Random().Next(1, 5).ToString();
    switch (x)
    {
        case "1":
            Tfigure(Array);
            break;
        case "2":
            Ofigure(Array);
            break;
        case "3":
            Ifigure(Array);
            break;
        case "4":
            Lfigure(Array);
            break;
        }
}


void CommandFigure(int[,] numbers)
{

    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
                if(numbers[i, j] == 1)
                {
                    numbers[i + 1, j - 1] = numbers[i, j];
                    System.Console.Write(numbers[i, j]);
                }
                System.Console.WriteLine();
            }
        }
    }


// void CommandFigure(int x, int y)
// {
//     if(Array[x, y] == 1)
//         {
//             Array[x + 1, y - 1] = Array[x, y];
//             CommandFigure(x - 1, y);
//             CommandFigure(x + 1, y);
//             CommandFigure(x, y - 1);
//             CommandFigure(x, y + 1);
//             System.Console.Write(Array[x, y]);
//         }
//     System.Console.WriteLine();
// }

// void FillPlusArray(int[,] numbers)
// {
//     string x = " ";
//     string y = "+";
//     for(int i = 0; i < numbers.GetLength(0); i++)
//     {
//         for(int j = 0; j < numbers.GetLength(1); j++)
//         {
//             if(numbers[i, j] == 0) System.Console.Write($"{x} ");
//             else System.Console.Write($"{y} ");
//         }
//         System.Console.WriteLine();
//     }
// }


PrintFigureArray();
// FillZeroArray(Array);
// FillPlusArray(Array);
CommandFigure(Array);


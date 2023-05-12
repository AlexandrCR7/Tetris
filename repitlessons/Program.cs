// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadIntM(string argument)
{
System.Console.WriteLine(argument);
int i;
while(!int.TryParse(System.Console.ReadLine(), out i)) {System.Console.WriteLine("Это не число");}
return i;
}


int ReadIntN(string argument)
{
System.Console.WriteLine(argument);
int i;
while(!int.TryParse(System.Console.ReadLine(), out i)) {System.Console.WriteLine("Это не число");}
return i;
}


int ReadIntS(string argument)
{
System.Console.WriteLine(argument);
int j;
while(!int.TryParse(System.Console.ReadLine(), out j)) {System.Console.WriteLine("Это не число");}
return j;
}


void FillArrayDouble(double[,] numbers)
{
    Random rnd = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round(rnd.Next(-100, 100) * 0.1, 2);
            System.Console.Write($"{numbers [i, j]} ");
        }
        System.Console.WriteLine();
    }
}


void FillArrayInt(int[,] numbers)
{
    Random rnd = new Random();
    int i = 0;
    int j = 0;
    for(i = 0; i < numbers.GetLength(0); i++)
    {
        for(j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(1, 10);
            System.Console.Write($"{numbers [i, j]} ");
        }
        System.Console.WriteLine();
    }
}


void SearchNumber(int[,] numbers)
{
    int x = ReadIntS("Введите число 3");
    int summ = 0;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            if(numbers[i, j] == x)
            {
                summ = summ + 1;
            }
        }
    }
    if(summ > 0)
    {
        System.Console.WriteLine("Да, " + summ + " раза");
    }
    else {System.Console.WriteLine("No");}
}

void Summ(int[,] numbers)
{
    int i;
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        double summ = 0;
        for(i = 0; i < numbers.GetLength(0); i++)
        {
             summ = summ + numbers[i, j];
        }
        System.Console.Write(Math.Round(summ/i, 1) + " ");
    }
}


void PrintArray()
{
    int m = ReadIntM("Введите число М");
    int n = ReadIntN("Введите число N");
    double[,] Array = new double[m, n];
    FillArrayDouble(Array);   
}

void PrintArrayInt()
{
    int m = ReadIntM("Введите число М");
    int n = ReadIntN("Введите число N");
    int[,] Array = new int[m, n];
    FillArrayInt(Array);   
    SearchNumber(Array);
}

void PrintMiddleSumm()
{
    int m = ReadIntM("Введите число М");
    int n = ReadIntN("Введите число N");
    int[,] Array = new int[m, n];
    FillArrayInt(Array); 
    Summ(Array);
}

PrintMiddleSumm();
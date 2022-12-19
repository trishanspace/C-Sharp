// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = Get2DArray(3, 4);
Print2DArray(array);
int minSumLine = GetMinimumValues(array);
int sumLine = GetSumLineElements(array, minSumLine);

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t  ");
        }
        Console.WriteLine();
    }
}

int[,] Get2DArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

int GetMinimumValues(int[,] array)
{
    int minSumLine = 0;
    int sumLine = GetSumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = GetSumLineElements(array, i);
        if (sumLine > temp)
        {
            sumLine = temp;
            minSumLine = i;
        }
    }
    return minSumLine;
}

int GetSumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
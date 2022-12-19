// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 18 18

int[,] firstMartrices = new int[2, 2];
GetArray(firstMartrices);
Console.WriteLine("Матрица А\t ");
PrintArray(firstMartrices);

int[,] secondMartrices = new int[2, 2];
GetArray(secondMartrices);
Console.WriteLine("Матрица В\t ");
PrintArray(secondMartrices);

int[,] resultMatrices = new int[2, 2];

GetProductTwoMatrices(firstMartrices, secondMartrices, resultMatrices);
Console.WriteLine("Произведение двух матриц:\t ");
PrintArray(resultMatrices);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void GetProductTwoMatrices(int[,] firstMartrices, int[,] secondMartrices, int[,] resultMatrices)
{
    for (int i = 0; i < resultMatrices.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrices.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrices.GetLength(1); k++)
            {
                sum += firstMartrices[i, k] * secondMartrices[k, j];
            }
            resultMatrices[i, j] = sum;
        }
    }
}
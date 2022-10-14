/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateIntMatrix(int rows, int columns)
{
    int[,] inputMatr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            inputMatr[i, j] = rnd.Next(0, 11);
    }
    return inputMatr;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
            Console.Write($"{inputMatrix[i, j]} \t");
        Console.WriteLine();
    }
}

int inputMatrSum(int row, int[,] inputMatr)
{
    int sum = 0;
    for (int i = 0; i < inputMatr.GetLength(1); i++)
    {
        sum = sum + inputMatr[row, i];
    }
    return sum;
}

int MinimumOfVector(int[] vec)
{
    int min = vec[0];
    int minIndex = 0;
    for (int i = 0; i < vec.Length; i++)
    {
        if (vec[i] < min)
        {
            min = vec[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}

int MinimalRow(int[,] matrix)
{
    int[] vectorOfSums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
        vectorOfSums[i] = inputMatrSum(i, matrix);
    return MinimumOfVector(vectorOfSums);
}

int height = 3;
int width = 4;
int[,] testMatrix = GenerateIntMatrix(height, width);
PrintMatrix(testMatrix);
Console.WriteLine();
int min = MinimalRow(testMatrix);
Console.WriteLine($"{min} row");

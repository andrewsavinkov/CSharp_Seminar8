/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GenerateIntMatrix(int rows, int columns)
{
    int[,] inputMatr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            inputMatr[i, j] = new Random().Next(0, 11);
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

int[,] SortMatrix(int[,] inputMatrix)
{
    int temp = 0;
    for (int m = 0; m < inputMatrix.GetLength(0); m++)
    {
        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            for (int j = 1; j < inputMatrix.GetLength(1); j++)
            {
                if (inputMatrix[i, j] > inputMatrix[i, j - 1])
                {
                    temp = inputMatrix[i, j - 1];
                    inputMatrix[i, j - 1] = inputMatrix[i, j];
                    inputMatrix[i, j] = temp;
                }
            }
        }
    }
    return inputMatrix;
}

int[,] testMatr = GenerateIntMatrix(3, 4);
PrintMatrix(testMatr);
Console.WriteLine();
int[,] sortedMatr = SortMatrix(testMatr);
PrintMatrix(sortedMatr);
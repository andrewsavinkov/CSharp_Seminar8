/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] matrix = new int[10, 10];
int initialCounter = 1;
void PrintMatrix(int[,] inputMatr)
{
    for (int i = 0; i < inputMatr.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatr.GetLength(1); j++)
        {
            Console.Write($"{inputMatr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FillArray(int row, int col)
{
    if (matrix[row, col] == 0)
    {
        matrix[row, col] = initialCounter;
        initialCounter++;
        if (col + 1 < matrix.GetLength(1) && row == 0)
            FillArray(row, col + 1);
        else if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == 0 && matrix[row - 1, col] != 0)
            FillArray(row, col + 1);
        else if (row + 1 != matrix.GetLength(0) && matrix[row + 1, col] == 0 /*&& col+1 == matrix.GetLength(1)*/)
            FillArray(row + 1, col);
        else if ((col - 1) >= 0 && row == matrix.GetLength(0)-1)
            FillArray(row, col - 1);
        else if ((col - 1) >= 0 && matrix[row, col-1]==0)
            FillArray(row, col - 1);
        else if (matrix[row - 1, col] == 0 && col == 0)
            FillArray(row - 1, col);
        else if (matrix[row - 1, col] == 0 && matrix[row, col - 1] != 0)
            FillArray(row - 1, col);
    }
}
PrintMatrix(matrix);
Console.WriteLine();
FillArray(0, 0);
PrintMatrix(matrix);
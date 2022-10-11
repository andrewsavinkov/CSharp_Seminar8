/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MatrixMultiplikation(int[,] matrA, int[,] matrB)
{
    int[,] result = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int n = 0; n < matrA.GetLength(0); n++)
            {
                result[i, j] = result[i, j] + matrA[i, n] * matrB[n, j];
            }
        }
    }
    return result;
}


int width = 3;
int height = 3;
int[,] matrOne=GenerateIntMatrix(height, width);
int[,] matrTwo=GenerateIntMatrix(height, width);

PrintMatrix(matrOne);
Console.WriteLine();
PrintMatrix(matrTwo);
Console.WriteLine();

int[,] res = MatrixMultiplikation(matrOne, matrTwo);
PrintMatrix(res);
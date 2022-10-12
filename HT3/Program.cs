/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[] HorizVectorExtractor(int row, int[,] inputMat)
{
    int[] resultVector = new int[inputMat.GetLength(1)];
    for (int i = 0; i < inputMat.GetLength(1); i++)
        resultVector[i] = inputMat[row, i];
    return resultVector;
}

int[] VertVectorExtractor(int col, int[,] inputMat)
{
    int[] resultVector = new int[inputMat.GetLength(0)];
    for (int i = 0; i < inputMat.GetLength(0); i++)
        resultVector[i] = inputMat[i, col];
    return resultVector;
}

int ScalarComposition(int[] vectorOne, int[] vectorTwo)
{
    int length = vectorOne.Length;
    int composition = 0;
    for (int i = 0; i < length; i++)
        composition = composition + vectorOne[i] * vectorTwo[i];
    return composition;
}

int[,] MatrixMultiplikation(int[,] matrA, int[,] matrB)
{
    if (matrA.GetLength(1) == matrB.GetLength(0))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = ScalarComposition(HorizVectorExtractor(i, matrA), VertVectorExtractor(j, matrB));
            }
        }
        return result;
    }
    else
    {
        Console.WriteLine("Error: Matrix dimensions must agree!");
        return result;
    }
}

int widthOne = 2;
int heightOne = 2;
int widthTwo = 2;
int heightTwo = 2;
int[,] matrOne = GenerateIntMatrix(heightOne, widthOne);
int[,] matrTwo = GenerateIntMatrix(heightTwo, widthTwo);

PrintMatrix(matrOne);
Console.WriteLine();
PrintMatrix(matrTwo);
Console.WriteLine();

int[,] resultingMatrix = MatrixMultiplikation(matrOne, matrTwo);
PrintMatrix(resultingMatrix);

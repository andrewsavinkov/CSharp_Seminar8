/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] GenerateThreeDMatrix(int rows, int cols, int depth)
{
    int[,,] result = new int[rows, cols, depth];
    int generatedNumber = 0;
    Random rnd = new Random();
    HashSet<int> listOfGeneratedNumbers = new HashSet<int>();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                do
                {
                    generatedNumber = rnd.Next(10, 100);
                } while (!listOfGeneratedNumbers.Add(generatedNumber));
                result[i, j, k] = generatedNumber;
            }

        }
    }
    return result;
}

void PrintMatrixThreeD(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(2); k++)
            {
                Console.Write($"{inputMatrix[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

int r = 10;
int c = 2;
int d = 2;
int[,,] testMatrix = GenerateThreeDMatrix(r, c, d);
PrintMatrixThreeD(testMatrix);
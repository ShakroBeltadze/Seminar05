// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string messageToUser)
{
    int value;
    do
    {
        Console.Write(messageToUser);
        value = Convert.ToInt32(Console.ReadLine());
    }
    while (value <= 0);
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write(matrix[i, j] + "   ");
            }
            else
            {
                Console.Write(matrix[i, j] + "  ");
            }

        }
        Console.WriteLine();
    }
}

void PrintMatrix1(double[] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        Console.Write(matrix[j] + "   ");
    }
}


double[] GetMeanMatrix(int[,] matrix)
{

    double[] RezMatrix = new double[matrix.GetLength(1)];


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        RezMatrix[j] = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            RezMatrix[j] += matrix[i, j];
        }
        RezMatrix[j] = RezMatrix[j] / matrix.GetLength(0);

    }
    return RezMatrix;

}


int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");

int[,] myMatrix = GetRandomMatrix(rows, colums);
PrintMatrix(myMatrix);

Console.WriteLine();

double[] meanMatrix = GetMeanMatrix(myMatrix);
PrintMatrix1(meanMatrix);

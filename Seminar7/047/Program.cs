// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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

double[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{

    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double a = Random.Shared.Next(leftBorder, rightBorder + 1);
            double b;
            do
            {
                b = Random.Shared.Next(leftBorder, rightBorder + 1);
            }
            while (b == 0);

            matrix[i, j] = Math.Round(a / b, 3);
            if (matrix[i, j] == -0.000)
            {
                matrix[i, j] = 0;
            }
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 0)
            {
                Console.Write("{0: 0.00}   ", matrix[i, j]);
            }
            else
            {
                Console.Write(" {0: 0.00}   ", matrix[i, j]);
            }
        }
        Console.WriteLine();
    }
}

int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");
double[,] myMatrix = GetRandomMatrix(rows, colums, -9, 9);
PrintMatrix(myMatrix);





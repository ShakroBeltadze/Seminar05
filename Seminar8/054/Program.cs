// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
            if (matrix[i, j] >= 100)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            else if (matrix[i, j] >= 10)
            {
                Console.Write(matrix[i, j] + "   ");
            }
            else 
            {
                Console.Write(matrix[i, j] + "    ");
            }

        }
        Console.WriteLine();
    }
}

void MaxRowsMatrix(int[,] matrix, int rows)
{
    int M;
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(1) - j; i++)
        {

            {
                if (matrix[rows, i + 1] < matrix[rows, i])
                {
                    M = matrix[rows, i];
                    matrix[rows, i] = matrix[rows, i + 1];
                    matrix[rows, i + 1] = M;
                }

            }

        }
    }

}

void MaxMatrix(int[,] matrix)
{

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        MaxRowsMatrix(matrix, j);
    }

}


int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");
int[,] myMatrix = GetRandomMatrix(rows, colums,0,100);
PrintMatrix(myMatrix);

Console.WriteLine("\r\n");

MaxMatrix(myMatrix);
PrintMatrix(myMatrix);











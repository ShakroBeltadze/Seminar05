// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


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





void ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }

}



int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");

int[,] myMatrix1 = GetRandomMatrix(rows, colums, 0, 10);
int[,] myMatrix2 = GetRandomMatrix(rows, colums, 0, 10);

PrintMatrix(myMatrix1);
Console.WriteLine($"\r\n");
PrintMatrix(myMatrix2);
Console.WriteLine($"\r\n");

ProductMatrix(myMatrix1,myMatrix2);
PrintMatrix(myMatrix1);

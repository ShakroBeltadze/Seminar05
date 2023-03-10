// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


void PrintMatrix1(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix[i] >= 100)
        {
            Console.Write(matrix[i] + "  ");
        }
        else if (matrix[i] >= 10)
        {
            Console.Write(matrix[i] + "   ");
        }
        else
        {
            Console.Write(matrix[i] + "    ");
        }


    }
}


void SummaRowsMatrix(int[,] matrix, int[] sumMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumMatrix[i] += matrix[i, j];
        }
    }

}

int FindMin(int[,] matrix, int[] sumMatrix)
{
    SummaRowsMatrix(matrix,sumMatrix);
    int Min=sumMatrix[0];
    int MinIndex=0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (Min>sumMatrix[i])
        {
            Min=sumMatrix[i];
            MinIndex=i;
        }
    }
    return MinIndex;
}


int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");

int[,] myMatrix = GetRandomMatrix(rows, colums, 0, 100);
PrintMatrix(myMatrix);


int[] summaMatrix = new int[rows];


Console.WriteLine($"\r\nВ {FindMin(myMatrix,summaMatrix)+1} строке минимальная сумму элементов в строке");


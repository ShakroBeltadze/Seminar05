// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет



int ReadNumber(string messageToUser, bool Min = true)
{
    int value;
    do
    {
        Console.Write(messageToUser);
        value = Convert.ToInt32(Console.ReadLine());
    }
    while ((value <= 0) && Min);
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

int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");
int[,] myMatrix = GetRandomMatrix(rows, colums);
PrintMatrix(myMatrix);

while (true)
{


    int rowsU = ReadNumber("Введите позицию элемента по строке: ", false);
    int columsU = ReadNumber("Введите позицию элемента по столбцу: ", false);


    if ((rowsU >= rows) || (columsU >= colums) || (rowsU < 0) || (columsU < 0))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Элемент [{rowsU},{columsU}] равен: {myMatrix[rowsU, columsU]}");
    }

    Console.WriteLine("Узнать значение еще одного элемента или stop");
    string Answer = Console.ReadLine();

    if (Answer.ToLower() == "stop")
    {
        break;
    }
}
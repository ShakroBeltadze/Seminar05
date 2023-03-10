// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

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
    int N = 1;
    int Step = 0;

    while (N <= rows * columns)
    {
        for (int x1 = Step; x1 < matrix.GetLength(1)-Step; x1++)
        {
            matrix[Step, x1] = N++;
        }
        if (N>rows * columns) break;
        for (int y1 = Step+1; y1 < matrix.GetLength(0)-Step; y1++)
        {
            matrix[y1, matrix.GetLength(1)-Step-1] = N++;
        }
        if (N>rows * columns) break;
        for (int x2 = matrix.GetLength(1)-Step-2; x2 > Step; x2--)
        {
            matrix[matrix.GetLength(0)-Step-1, x2] = N++;
        }
        if (N>rows * columns) break;
        for (int y2 = matrix.GetLength(0)-Step-1; y2 > Step; y2--)
        {
            matrix[y2, Step] = N++;
        }
        if (N>rows * columns) break;
        Step++;
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

int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");
int[,] myMatrix = GetRandomMatrix(rows, colums);
PrintMatrix(myMatrix);





// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

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

int[,,] GetRandomMatrix(int rows, int columns, int layers, int leftBorder = 0, int rightBorder = 10)
{

    int[,,] matrix = new int[rows, columns, layers];

    int[] number = new int[100];
    int X;

    for (int z = 0; z < matrix.GetLength(2); z++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                while (true)
                {
                    X = Random.Shared.Next(leftBorder, rightBorder + 1);
                    if (number[X] == 0)
                    {
                        matrix[i, j, z] = X;
                        number[X]++;
                        break;
                    }
                }
            }
        }

        
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, z]}  ({i},{j},{z})  ");

            }
            Console.WriteLine();
        }

    }

}






int rows = ReadNumber("Введите количество строк: ");
int colums = ReadNumber("Введите количество столбцов: ");
int layers = ReadNumber("Введите количество слоёв: ");

int[,,] myMatrix = GetRandomMatrix(rows, colums, layers, 10, 99);


PrintMatrix(myMatrix);

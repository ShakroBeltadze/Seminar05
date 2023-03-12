// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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


void Print(int N)
{
    if (N < 1) return;
    Console.Write($"{N} ");
    Print(N-1);
}


int N = ReadNumber("Введите значение N: ");

Print(N);
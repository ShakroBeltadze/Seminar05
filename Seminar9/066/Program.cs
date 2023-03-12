// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


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




int SummaMtoN(int N, int M)
{
    if (N < M) return 0;

    return N + SummaMtoN(N - 1, M);
}


int N = ReadNumber("Введите значение N: ");

int M = ReadNumber("Введите значение M: ");

Console.WriteLine($"Cумма натуральных элементов в промежутке от {M} до {N}: {SummaMtoN(N, M)}");
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


ulong ReadNumber(string messageToUser)
{
    ulong value;
    do
    {
        Console.Write(messageToUser);
        value = Convert.ToUInt64(Console.ReadLine());
    }
    while (value < 0);
    return value;
}

ulong ack(ulong n, ulong  m)
{
    if (n == 0)
    {
        return m+1;
    }
    else if (m == 0)
    {
        return ack(n - 1, 1);
    }
    else
    {
        return ack(n - 1, ack(n, m - 1));
    }

}


ulong  M = ReadNumber("Введите значение M: ");

ulong N = ReadNumber("Введите значение N: ");

Console.WriteLine($"Функции Аккермана для числа {M} и {N}: {ack(M, N)}");
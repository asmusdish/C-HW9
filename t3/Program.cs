// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double AkkermanFunction(double M, double N)
{
    if (M == 0) return N + 1;
    else
    {
        if (M != 0 && N == 0)
            return AkkermanFunction(M - 1, 1);
        else
        {
            return AkkermanFunction(M - 1, AkkermanFunction(M, N - 1));
        }
    }
}

Console.Write("Введите значение числа M: ");
if (!int.TryParse(Console.ReadLine(), out int M) || M < 0)
{
    Console.WriteLine("Введено неверное число");
    return;
}

Console.Write("Введите значение числа N: ");
if (!int.TryParse(Console.ReadLine(), out int N) || N < 0)
{
    Console.WriteLine("Введено неверное число");
    return;
}

double result = AkkermanFunction(M, N);
Console.WriteLine(result);
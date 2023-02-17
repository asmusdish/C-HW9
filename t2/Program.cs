// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int M, int N)
{
if (M <= N)
    {
        if(M == N) return N;
        else return N + SumNumbers(M, N - 1);
    }
else return M + SumNumbers(M - 1, N);
}

  Console.Write("Введите значение числа M: ");
    if (!int.TryParse(Console.ReadLine(), out int M) || M <= 0)
        {
        Console.WriteLine("Введено не натуральное число");
        return;
        }

  Console.Write("Введите значение числа N: ");
    if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
        Console.WriteLine("Введено не натуральное число");
        return;
        }

int result = SumNumbers(M, N);
Console.WriteLine(result);

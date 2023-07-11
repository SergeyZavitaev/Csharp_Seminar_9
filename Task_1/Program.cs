// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Random rand = new Random();

int SumBetween2Numbers(int M, int N, int sum = 0)
{
    if (N == M - 1) return sum;
    sum = sum + N;
    return SumBetween2Numbers(M, N - 1, sum);
}

int Num1 = rand.Next(1, 30);
int Num2 = rand.Next(1, 30);

if (Num1 < Num2)
{
    Console.WriteLine($"Число 1 = {Num1}");
    Console.WriteLine($"Число 2 = {Num2}");
    Console.WriteLine(SumBetween2Numbers(Num1, Num2));
}
else
{
    Console.WriteLine($"Число 1 = {Num2}");
    Console.WriteLine($"Число 2 = {Num1}");
    Console.WriteLine(SumBetween2Numbers(Num2, Num1));
}
// Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Random rand = new Random();

int AckermannFunction(int M, int N)
{
    if (M == 0) { return (N+1); }
    if (M>0 & N==0) { return AckermannFunction(M - 1, 1); }
    if (M > 0 & N > 0)
    { //Console.WriteLine(", m- " + M + ":,n-" + N);
        return AckermannFunction(M - 1,
        AckermannFunction(M, N - 1) ); 
    }
    else { return -1; }
}

int NumM = rand.Next(1, 4);
Console.WriteLine($"Число M = {NumM}");
int NumN = rand.Next(1, 6);
Console.WriteLine($"Число N = {NumN}");

Console.WriteLine(AckermannFunction(NumM, NumN));

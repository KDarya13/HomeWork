//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunAkker(int m,int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return FunAkker(m - 1, 1);
    if(m > 0 && n > 0) return FunAkker(m - 1, FunAkker(m, n-1));
    else return 0;
}

Console.WriteLine("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = FunAkker(a,b);
Console.WriteLine(res);
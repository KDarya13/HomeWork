//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current <= n)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;
}



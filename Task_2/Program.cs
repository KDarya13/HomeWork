//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"max = {a} min = {b}");
}
else
{
    Console.WriteLine($"max = {b} min = {a}");
}
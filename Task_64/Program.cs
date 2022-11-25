// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{   
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n-1);
  
}
Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

ShowNumbers(a);







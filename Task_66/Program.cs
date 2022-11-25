//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int FindSumNum(int n, int m)
{
  
    if(m == n) return m;
    
    if(m <= n) return FindSumNum(n, m + 1)+ m;
    
    else return FindSumNum(n + 1, m)+ n;
    
}    

Console.WriteLine("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int sum = FindSumNum(a,b);
Console.WriteLine($"Сумма натуральных элементов = {sum}");
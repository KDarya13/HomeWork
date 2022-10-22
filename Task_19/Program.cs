//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrome(int number)
{
    int num1 = number / 10000;
    int num5 = number % 10;
    int num2 = (number / 1000) % 10;
    int num4 = (number % 100) / 10;
    if(num1 == num5 & num2 == num4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Input a five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

bool res = Palindrome(n);

Console.WriteLine($"This is a number palindrome: {res}");
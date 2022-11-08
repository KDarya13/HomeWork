//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the digits of the number {a} is {SumDigit(a)}");



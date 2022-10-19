//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int SecondNumber(int number)
{
    int num = (number / 10) % 10;
    return num;
}

Console.WriteLine("Input a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(n);

Console.WriteLine($"The second number is: {result}");

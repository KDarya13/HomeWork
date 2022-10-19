//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber(int number)
{
    while(number > 999 & number < 1000000)
    {
        number = number / 10;
    }
    if(number > 99 & number < 1000)
    {
       int num = number % 10;
       return num;
    }
    else
    {
        if(number < 100)
        {
            Console.WriteLine("There is no third number");
        }
    }
    return number;
}

Console.WriteLine("Input number: ");

int n = Convert.ToInt32(Console.ReadLine());

int result = ThirdNumber(n);

Console.WriteLine($"Third number is: {result}");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int number)
{
       if(number == 6 || number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }    
}

Console.WriteLine("Input the number of the day of the week:");

int day = Convert.ToInt32(Console.ReadLine());

bool result = Weekend(day);

Console.WriteLine($"This day is the weekend: {result}");

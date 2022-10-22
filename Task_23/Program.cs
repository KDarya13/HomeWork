//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int number)
{
    int cur = 1;
    if(number > 0)
    {
        while(cur <= number)
        {   
            Console.Write(cur * cur * cur + " ");
            cur++;
        } 
    }
    else
    {
        Console.Write("This number is negative");
    }   

}

Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Cube(a);

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


double Degree(int number_a, int number_b)
{
    double degree = Math.Pow(number_a, number_b);
    return degree;
}
Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number A to the degree of the number B: {Degree(A,B)}");


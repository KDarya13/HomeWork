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
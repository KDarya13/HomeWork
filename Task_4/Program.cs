Console.WriteLine("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(a < b)
{
    max = b;
}
else
{
    max = a;
}
if(max > c)
{
    Console.WriteLine("max = " + max);
}
else
{
    Console.WriteLine("max = " + c);
}

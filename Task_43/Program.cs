//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


void Equal(double b1,double b2,double k1,double k2)
{    
    if(k1 == k2 && b1 == b2)
    
        Console.WriteLine("Прямые совпадают");
    
    else if(k1 == k2)

        Console.WriteLine("Прямые параллельны друг другу");

    else
        Console.WriteLine("Прямые не параллельны друг другу и не совпадают");

}

double IntersectionPoinX(double b1,double b2,double k1,double k2)
{   
    double x = (b2-b1)/(k1-k2);
    return x;
     
}

double IntersectionPoinY(double b1,double b2,double k1,double k2)
{   
  
    double y = k1*(b2-b1)/(k1-k2) + b1;
    return y;
}


Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());



Equal(b1,b2,k1,k2); 
Console.WriteLine(Equal);
Console.WriteLine();
double resX = IntersectionPoinX(b1,b2,k1,k2);
Console.Write($"Точка пересечения прямых находится в точке с координатами: X {resX} ");
double resY = IntersectionPoinY(b1,b2,k1,k2);
Console.Write($"Точка пересечения прямых находится в точке с координатами: Y {resY} ");




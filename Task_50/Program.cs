//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateRandom2dArray(int rows,int columns,int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    
       for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       
            Console.Write(array[i,j] + " "); 
       
       Console.WriteLine();
    }   
}

void BorderArray(int[,] array, int r, int c)
{
    if(r > array.GetLength(0)  || c > array.GetLength(1))

        Console.WriteLine("Массив не содержит элемента с введёнными параметрами");

    else
        
        Console.WriteLine(array[r,c]);
        
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a index of row: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a index of column: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n , min, max);
Show2dArray(myArray);
Console.WriteLine();

BorderArray(myArray,a,b);




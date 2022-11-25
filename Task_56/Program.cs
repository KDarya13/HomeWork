//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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


void FindMinSum(int[,] array, int rows, int columns)
{
    int minsum = Int32.MaxValue;
    int sum = 0;
    int imin = 0;

    for(int i = 0; i < rows; i++)
    {           
        for(int j = 0; j < columns; j++)
        {
            sum+=array[i,j];
        }
            

        if(sum <= minsum)
        {
            minsum = sum;
            imin = i;
            sum = 0;
        }
        
    }  
    Console.WriteLine($"Minimum sum is: {minsum} row is {imin}");  
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n , min, max);
Show2dArray(myArray);
Console.WriteLine();

FindMinSum(myArray,m,n);




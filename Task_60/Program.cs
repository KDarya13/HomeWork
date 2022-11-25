// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] CreateRandom3dArray(int rows, int columns, int size, int max)
{
    int[,,] array = new int[rows,columns,size];
    int maxsize = 90;
    int min = 10;

    if(rows * columns * size < maxsize)
    {
        if(min < max && max <= 99)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    for(int k = 0; k < size; k++)
                    {
                           
                        array[i,j,k] = min;
                        min++;
                                    
                    }
                }
            }
        }       
    }        
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)

                Console.Write(array[i,j,k] + $"({i},{j},{k})" + " "); 
        }
        Console.WriteLine();
    }   
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of size: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(m, n, l, max);
Show3dArray(myArray);

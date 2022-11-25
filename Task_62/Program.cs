// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRandom2dArray(int size)
{   
    size = 4;
    int i = 0, j = 0;
    
    int numofarray = 1;

    int[,] array = new int[size,size];

    while(size * size >= numofarray)
    {    
        array[i,j] = numofarray;  

        if(i <= j + 1 && i + j < size-1) 
            
            j++;
        
        else if (i < j && i + j >= size-1)
        {   
            i++;
        }
        else if(i >= j && i + j > size-1)

            j--;

        else 
        {
            i--;
        }
        numofarray ++;
    }
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
int m = 4;
int[,] myArray = CreateRandom2dArray(m);
Show2dArray(myArray);
Console.WriteLine();
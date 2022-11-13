//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)

        array[i] = new Random().NextDouble() * 100;
        
      
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length;i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double FindDiff(double[] array)
{   
    double diff = 0;
    int posmax = 0;
    int posmin = 0;
     

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > array[posmax])
        
            posmax = i;
                    
        
        if(array[i] < array[posmin])
        
            posmin = i;
        
        diff = array[posmax] - array[posmin];     
       
    }
    return diff;
}


Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(n);
ShowArray(myArray);

double finddiffmaxmin = FindDiff(myArray);
finddiffmaxmin = Math.Round(finddiffmaxmin,2);
Console.WriteLine($"The difference between the maximum number and the minimum number is: {finddiffmaxmin}");
    

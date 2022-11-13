//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)

        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length;i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
} 

int FindCountEven(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(100 <= array[i] & array[i] < 1000 & array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int counteven = FindCountEven(myArray);
Console.WriteLine($"The number of even numbers in the array {counteven}");


//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите количество чисел в массиве: ");
int numbersArray = int.Parse(Console.ReadLine());

int[] array = new int[numbersArray];

int count = 0;

for(int i = 0; i < array.Length; i++) 
{   
    Console.Write($"Число массива с индексом {i} = ");
    array[i] = int.Parse(Console.ReadLine());

}

for(int i = 0; i < array.Length; i++) 
{   
    if(array[i] > 0)
    
        count++;

    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"количество положительных чисел в массиве = {count}");
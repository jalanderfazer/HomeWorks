/* Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

* [“Russia”, “Denmark”, “Kazan”] → []

*/

string[] DefaultArray(int count)
{
    int size = count;
    string[] array = new string[size];

    for( int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element, please: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] NewArray(string[] inputArray, int length)
{
    int size = inputArray.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (inputArray[i].Length <= length) count ++;
    }

    string[] outputArray = new string[count];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (inputArray[i].Length <= length) 
        {
            outputArray[j] = inputArray[i];
            j++;
        }
    }
    return outputArray;
}

void PrintArray(string[] array)
{
    int size = array.Length;
    for( int i = 0; i < size; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (size - 1)) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

int length = 3;
Console.WriteLine("Enter size of the array, please: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] inputArray = DefaultArray(size);
PrintArray(inputArray);
Console.WriteLine();

string[] outputArray = NewArray(inputArray,length);
PrintArray(outputArray);
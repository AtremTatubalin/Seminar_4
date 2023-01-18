//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] getArrayRandom(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i <= len; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}


void showArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}

int[] array = getArrayRandom(8);

showArray(array);
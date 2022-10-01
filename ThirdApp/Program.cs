//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
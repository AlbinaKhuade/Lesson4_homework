// Задача 29: Напишите программу, которая
// задаёт массив из 8 элементов и
// выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] FillArray(int num)
{
    int[] array = new int[num]; // создаем массив из num элементов из нулей изначально
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}

int[] myArr = FillArray(8);
PrintArray(myArr);
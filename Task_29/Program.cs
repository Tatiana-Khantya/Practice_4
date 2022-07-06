// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] array = new int[num];

void FillArray(int[] collection)
{
        int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int length = col.Length;
    int i = 0;
    while (i < length)
    {
        Console.Write($"{col[i]}, ");
        i++;
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);
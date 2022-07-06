// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Sum(int Num)
{
    int i = 0;
    int k = 0;
    while (Num > 0)
    {
        i++;
        k = k + Num % 10;
        Num /= 10;
    }
    return k;
}
int result = Sum(num);
Console.WriteLine($"Сумма цифр числа {num} = {result}");
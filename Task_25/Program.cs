// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа");
Console.Write("Число A = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Число B = ");
int b = int.Parse(Console.ReadLine());

int Step(int x, int y)
{
    int k = 1;
    for (int i = 1; i <= y; i++)
    {
        k = k * x;
    }
    return k;
}
int result = Step(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");
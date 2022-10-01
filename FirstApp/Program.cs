// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetNumberA()
{
    Console.Write("Введите число А: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberB()
{
    Console.Write("Введите число B: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Power()
{
    int a = GetNumberA();
    int b = Math.Abs(GetNumberB());
    int pow = 1;
    for (int i = 0; i < b; i++)
    {
        pow = pow * a;
    }
    return pow;
}

Console.WriteLine($"Число А в степени В равно {Power()}");
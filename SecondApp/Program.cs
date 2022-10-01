// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int Number)
{
    int summa = 0;
    while (Math.Abs(Number) > 0)
    {
        int digit = Number % 10;
        summa = summa + digit;
        Number = Number / 10;
    }
    return summa;
}
int Number = GetNumber();
Console.WriteLine($"Сумма всех чисел в числе {Number} равна {SumOfDigits(Number)}.");
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void GetPow (int number)
{
    for (int i = 1; i <= number; i ++)
    {
        System.Console.WriteLine(Math.Pow(i, 2));
    }
}
GetPow(5);
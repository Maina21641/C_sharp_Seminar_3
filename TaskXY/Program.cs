// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

System.Console.WriteLine();

int N = new Random().Next(1, 5);
string range = "";
string num = "";

if (N == 1) range = "x > 0, y > 0";
else if (N == 2) range = "x < 0, y > 0";
else if (N == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

System.Console.WriteLine($"Для {N}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");
System.Console.WriteLine();

// Вариант Ребят

string GetRanges(int n)
{
    switch (n)
    {
    case 1:
        return "x > 0 and y > 0";
    case 2:
        return "x < 0 and y > 0";
    case 3:
        return "x < 0 and y < 0";
    case 4:
        return "x > 0 and y < 0";
    default:
        return "error";
    }
}

System.Console.WriteLine(GetRanges(2));
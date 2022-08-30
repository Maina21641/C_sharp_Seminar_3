// 1. Написать программу показывающуб вторую цифру трехзначного числа

// int GetSecondDigit(int number){
//     return number / 10 % 10;
// }
// Random rnd = new Random();
// int n = 123;

// // uint //unsigned // Math.Abs
// System.Console.WriteLine($"Вторая цифра числа {n} - {GetSecondDigit(n)}");

// 2. Написать программу вывода третьей цифру любого числа

int GetSecondDigit(int number){
    if (number < 100){
        System.Console.WriteLine("Третьей цифры нет");
        return 0;
    }
    int result = 0;
    while (number > 999){ // пока число больше максимального трехзначного 
        number /= 10; // делим на 10 пока разряды не упадут до трехзначного
        result = number % 10; // выводим третий знак
    }
    return result;
}

System.Console.WriteLine(GetSecondDigit(5975613));



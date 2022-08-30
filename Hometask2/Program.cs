// 1. Написать программу показывающуб вторую цифру трехзначного числа

// int GetSecondDigit(int number){
//     return number / 10 % 10;
// }
// Random rnd = new Random();
// int n = 123;

// // uint //unsigned // Math.Abs
// System.Console.WriteLine($"Вторая цифра числа {n} - {GetSecondDigit(n)}");

// 2. Написать программу вывода третьей цифру любого числа

// int GetSecondDigit(int number){
//     if (number < 100){
//         System.Console.WriteLine("Третьей цифры нет");
//         return 0;
//     }
//     int result = 0;
//     while (number > 999){ // пока число больше максимального трехзначного 
//         number /= 10; // делим на 10 пока разряды не упадут до трехзначного
//         // number = number / 10; аналогична предыдущей строке
//         result = number % 10; // выводим третий знак
//     }
//     return result;
// }

// System.Console.WriteLine(GetSecondDigit(5975613));

// 2.1 Вариант вывода третьей цифры из кокретного числа с помощью массива

// int GetSecondDigit(int number){
//     int[] arr = new int[7];
//     for (int i =0; number > 0; i ++){
//         arr[i] = number % 10;
//         number /=10;
//     }
//     return arr [arr.Length - 3];
// }
// System.Console.WriteLine(GetSecondDigit(5975613));

// 3.  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsWeekend(int number){
    if (number > 7 || number < 1){
        return false;
    }
    if (number > 5){
        return true;
    }
    else{
        return false;
    }
}
Console.WriteLine(IsWeekend(9));
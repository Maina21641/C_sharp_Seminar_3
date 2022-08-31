// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой находится эта точка.

int GetQuarter (int x, int y){
    if (x > 0 && y > 0){
        return 1;
    }
    else if (x < 0 && y > 0){
        return 2;
    }
    else if (x < 0 && y < 0){
        return 3;
    }
    else if (x > 0 && y < 0){
        return 4;
    }
    else{
        System.Console.WriteLine("Координаты введены неверно");
        return -1;
    }
}
System.Console.WriteLine(GetQuarter(5, -10));
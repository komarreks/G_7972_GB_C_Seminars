//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Считывание данных
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

//Рекурсивное суммирование
int PrintSumNatural(int m, int n){
    if(m == n){
        return n;
    }

    return m + PrintSumNatural(m+1,n);
}

//Получаем величину диапазона
int m = ReadData("Введите число от");
int n = ReadData("Введите число до");

//Выводим итог
Console.WriteLine($"M = {m}; N = {n} -> {PrintSumNatural(m,n)}");
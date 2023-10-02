//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//Считывание данных
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

//Вывод числа
void PrintNum(int num){
    if(num > 1){
        Console.Write(num + ", ");
        PrintNum(num-1);
    }else{
        Console.Write(1);
    }    
}

//Получаем начальное значение
int num = ReadData("Укажите число N");

//Выводим числа
PrintNum(num);

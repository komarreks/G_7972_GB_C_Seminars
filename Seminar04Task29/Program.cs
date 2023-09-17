//Считывание числа
int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

//генерация массива заданной длинны и со значениями из диапазона
int[] GenArray(int length, int startNumber, int endNumber){
    Random random = new Random();

    int[] arr = new int[length];

    for(int i = 0; i < length; i++){
        arr[i] = random.Next(startNumber, endNumber+1);
    }

    return arr;
}

//Печать массива
void PrintArray(int[] arr){
    Console.Write("[");

    for(int i=0; i<arr.Length-1; i++){
        Console.Write(arr[i] + ", ");
    }

    Console.Write(arr[arr.Length-1] + "]");
}

//считываем длинну и диапазон значений
int length     = ReadData("Введите длинну массива:");
int startDigit = ReadData("укажие диапазон от:");
int endDigit   = ReadData("до:");

//генерируем и печатаем массив
Console.WriteLine("Получившийся массив:");
PrintArray(GenArray(length, startDigit, endDigit));
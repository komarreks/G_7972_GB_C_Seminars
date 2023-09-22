//Генерация массива
int[] ArrayGenerator(int length, int startValue, int endValue){
    Random random = new Random();

    int[] array = new int[length];

    for(int i = 0; i < length; i++)
        array[i] = random.Next(startValue, endValue + 1);
    
    return array;
}

//Вывод массива
void PrintArray(int[] arr){
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ", ");
    }

    Console.Write(arr[arr.Length-1] + "]");

    Console.WriteLine();
}

//Сумма элементов нечетных позиций
int SummNotEvenPosition(int[] array){
    int summ = 0;

    for(int i = 0; i < array.Length; i = i+2){
        summ = summ + array[i];
    }

    return summ;
}

//вывод пар
void PrintAllPairs(int[] array){
    for(int i = 1; i < array.Length; i = i+2){
        Console.WriteLine(array[i-1] + " и " + array[i]);
    }
}

//Генерируем массив
int[] array = ArrayGenerator(11, 1, 10);
PrintArray(array);

//Считаем сумму на нечетных позициях
int summNotEvenPosition = SummNotEvenPosition(array);
Console.WriteLine("Сумма элементов нечетных позиций: " + summNotEvenPosition);

//Выводим пары
Console.WriteLine("Пары массива");
PrintAllPairs(array);
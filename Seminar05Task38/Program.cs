//Генерация массива целых чисел с диапазоном значений
int[] ArrayGenerator(int length, int startValue, int endValue){
    Random random = new Random();

    int[] array = new int[length];

    for(int i = 0; i < length; i++)
        array[i] = random.Next(startValue, endValue + 1);
    
    return array;
}

//Генерация массива вещественных чисел
double[] ArrayGeneratorDouble(int length){
    Random random = new Random();

    double[] array = new double[length];

    for(int i = 0; i < length; i++)
        array[i] = random.NextDouble()*1000;
    
    return array;
}

//Поиск разницы между минимальным и максимальным значением массива
double DifferentMinMax(double[] array){
    double min = array[0];
    double max = array[0];

    for(int i = 0; i < array.Length; i++){
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }

    return max - min;
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

//Вывод вещественного массива
void PrintDoubleArray(double[] arr){
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ", ");
    }

    Console.Write(arr[arr.Length-1] + "]");

    Console.WriteLine();
}

//Сортировка вставкой
void InsertSort(int[] array){
    for(int i=1; i < array.Length; i++)
        {
            int k = array[i];
            int j = i - 1;

            while(j>=0 && array[j] > k)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = k;
        }
}

//Сортировка методом подсчета
void BasicCountingSort(int[] array, int k)
{
    var count = new int[k + 1];
    for (var i = 0; i < array.Length; i++)
    {
        count[array[i]]++;
    }

    var index = 0;
    for (var i = 0; i < count.Length; i++)
    {
        for (var j = 0; j < count[i]; j++)
        {
            array[index] = i;
            index++;
        }
    }
}


//Генерируем массив вещественных чисел
double[] arrayOfDouble = ArrayGeneratorDouble(10);
PrintDoubleArray(arrayOfDouble);
//находим разницу между минимальным и максимальным значением
Console.WriteLine("Разница между максимальным и минимальным значением: " + DifferentMinMax(arrayOfDouble));

Console.WriteLine();
//Задача со свездочкой
//Генерируем массив
int[] array = ArrayGenerator(20, 1, 100);
PrintArray(array);

//Сортируем вставкой
InsertSort(array);
PrintArray(array);

//Покажем разницу
Console.WriteLine("Разница между минимальным и максимальным: " + (array[array.Length-1] - array[0]));

Console.WriteLine();
//Генерируем массив
int[] array2 = ArrayGenerator(20, 1, 100);
PrintArray(array2);

//Сортируем подсчетом
BasicCountingSort(array2, 100);
PrintArray(array2);

//Покажем разницу
Console.WriteLine("Разница между минимальным и максимальным: " + (array2[array2.Length-1] - array2[0]));
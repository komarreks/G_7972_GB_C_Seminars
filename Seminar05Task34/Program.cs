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

//Подсчет четных
int CountEven(int[] array){
    int count = 0;

    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) count++;
    }

    return count;
}

//Пузырьковая сортировка
void BubbleSort(int[] array) {  
    Boolean sorted = false;
    int temp;
    while(!sorted) {
        sorted = true;
        for (int i = 0; i < array.Length - 1; i++) {
            if (array[i] > array[i+1]) {
                temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
                sorted = false;
            }
        }
    }
}


//Генерируем нужный массив
int[] array = ArrayGenerator(100, 100, 999);
PrintArray(array);

//Считаем количество четных
int countEven = CountEven(array);

//Сортируем
BubbleSort(array);

//Выводим отсортированный массив и количество четных
Console.WriteLine("Отсортированный массив");
PrintArray(array);
Console.WriteLine("Количество четных элементов: " + countEven);

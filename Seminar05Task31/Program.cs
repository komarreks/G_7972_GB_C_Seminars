//Генерация массива заданной длинны с диапазоном значений
int[] ArrayGenerator(int length, int startValue, int endValue){
    Random random = new Random();

    int[] array = new int[length];

    for(int i = 0; i < length; i++)
        array[i] = random.Next(startValue, endValue + 1);
    
    return array;
}

//поиск сумм отрицательных и положительных элементов массива
int[] getSummNegrivePositive(int[] array){
    int[] summNegativePositive = new int[2];

    for(int i = 0; i < array.Length; i++){
        byte index = 0;
        if(array[i] > 0){
            index = 1;
        }else index = 0;

        summNegativePositive[index] = summNegativePositive[index] + array[i];
    }

    return summNegativePositive;
}

void PrintArray(int[] arr){
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ", ");
    }

    Console.Write(arr[arr.Length-1] + "]");
}

//генерируем массив
int[] array = ArrayGenerator(12, -9, 9);

PrintArray(array);

int[] summ = getSummNegrivePositive(array);

Console.WriteLine("Сумма отрицательных чисел: " + summ[0] + ", сумма положительных чисел: " + summ[1]);



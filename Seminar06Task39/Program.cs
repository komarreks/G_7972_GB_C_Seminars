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

int[] SwapNewArray(int[] array){
    int[] resultArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++){
        resultArray[i] = array[array.Length-1-i];
    }

    return resultArray;
}

void SwapArray(int[] array){
    for(int i = 0; i<array.Length/2; i++){
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}

int[] array = ArrayGenerator(10, 1, 10);
PrintArray(array);
PrintArray(SwapNewArray(array));

int[] array2 = ArrayGenerator(10, 1, 10);
PrintArray(array2);
SwapArray(array2);
PrintArray(array2);
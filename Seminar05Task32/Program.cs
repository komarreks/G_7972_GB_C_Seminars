int[] ArrayGenerator(int length, int startValue, int endValue){
    Random random = new Random();

    int[] array = new int[length];

    for(int i = 0; i < length; i++)
        array[i] = random.Next(startValue, endValue + 1);
    
    return array;
}

void InvertDigitsOfArray(int[] array){
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;
}

void PrintArray(int[] arr){
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ", ");
    }

    Console.Write(arr[arr.Length-1] + "]");
}

int[] array = ArrayGenerator(4, -10, 10);

PrintArray(array);

InvertDigitsOfArray(array);

PrintArray(array);
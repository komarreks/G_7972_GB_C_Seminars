int[] ArrayGenerator(int length, int startValue, int endValue){
    Random random = new Random();

    int[] array = new int[length];

    for(int i = 0; i < length; i++)
        array[i] = random.Next(startValue, endValue + 1);
    
    return array;
}

void PrintArray(int[] arr){
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ", ");
    }

    Console.Write(arr[arr.Length-1] + "]");

    Console.WriteLine();
}

int Count10_99(int[] array){
    int count = 0;

    for(int i = 0; i < array.Length; i++){
        if(array[i]>=10 && array[i]<=99) count++;
    }

    return count;
}

int[] array = ArrayGenerator(123, -100, 100);

PrintArray(array);

Console.WriteLine(Count10_99(array));
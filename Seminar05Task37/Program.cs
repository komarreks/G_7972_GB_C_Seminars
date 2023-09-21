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

int[] SummCouples(int[] array){
    Boolean even = array.Length % 2 == 0;

    int[] resultArray = new int[array.Length / 2 + (even ? 0 : 1)];

    int start = 0;
    int end = array.Length -1;

    while(start < end){
        resultArray[start] = array[start]*array[end];
        start++;
        end--;
    }

    if(!even){
        resultArray[start] = array[start];
    }

    return resultArray;

}

int[] array = ArrayGenerator(5, 1, 5);
PrintArray(array);

int[] resultArray = SummCouples(array);

PrintArray(resultArray);
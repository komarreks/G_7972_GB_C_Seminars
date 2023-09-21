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
}

Boolean FindDigitToArray(int digit, int[] array){
    for(int i =0; i < array.Length; i++)
        if(array[i] == digit) return true;

    return false;
}

int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

int[] array = ArrayGenerator(12, -10, 10);

PrintArray(array);

int digit = ReadData("Массив сгенерирован, введите искомое число:");

Boolean find = FindDigitToArray(digit, array);

if(find){
    Console.WriteLine("Число найдено");
}else{
    Console.WriteLine("Число не найдено");
}
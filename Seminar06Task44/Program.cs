//Считывание числа
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

int[] Fibo(int length){
    int[] array = new int[length];

    for(int i = 0; i < length; i++){
        if(i==0) array[i] = 0;
        if(i==1) array[i] = 1;

        if(i>1){
            array[i] = array[i-1] + array[i-2];
        }
    }

    return array;
}

int length = ReadData("Введите длинну ряда");

int[] arrayFibo = Fibo(length);

Console.WriteLine(string.Join(", ", arrayFibo));
int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

void PrintArray(int[] arr){
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ", ");
    }

    Console.Write(arr[arr.Length-1] + "]");
}

int[] GenArr(){
    int[] arr = new int[8];

    Random random = new Random();

    for(int i = 0; i < arr.Length; i++){
        arr[i] = random.Next(0,2);
    }

    return arr;
}


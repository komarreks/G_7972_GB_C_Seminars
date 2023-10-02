int[,] ArrayGenerator2D(int countRaw, int countColumn, int topBorder, int downBorder){
    Random random = new Random();

    int[,] array2D = new int[countRaw,countColumn];

    for(int i = 0; i < countRaw; i++)
        for(int j = 0; j < countColumn; j++)
            array2D[i,j] = random.Next(downBorder, topBorder);
    
    return array2D;
}

void Print2DArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            if(i == j) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(array[i,j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();    
    }    
}

int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

void Change2DArray(int[,] array){
    int temp;
    for(int i = 0; i < array.GetLength(1); i++){
        temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;
    }
}

int[,] arrray = ArrayGenerator2D(5,6,10,0);
Print2DArray(arrray);

Console.WriteLine();

Change2DArray(arrray);

Print2DArray(arrray);
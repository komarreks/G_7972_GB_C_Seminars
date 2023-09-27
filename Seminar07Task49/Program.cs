//Считывание числа
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

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
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();    
    }    
}

void FillEvenIndexPow(int[,] array){
    for(int i = 0; i < array.GetLength(0); i = i + 2)
        for(int j = 0; j < array.GetLength(1); j = j + 2)
            array[i,j] = array[i,j] * array[i,j];
}

int row = ReadData("Строк");
int col = ReadData("Столбцов");

int[,] array = ArrayGenerator2D(row, col, 10, 1);

Print2DArray(array);

FillEvenIndexPow(array);

Console.WriteLine();

Print2DArray(array);


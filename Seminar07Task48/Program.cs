int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

int[,] Fill2DSummInd(int countRaw, int countColumn){
    Random random = new Random();

    int[,] array2D = new int[countRaw,countColumn];

    for(int i = 0; i < countRaw; i++)
        for(int j = 0; j < countColumn; j++)
            array2D[i,j] = i + j;
    
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

int row = ReadData("Количество строк");
int column = ReadData("Количество столбцов");

int[,] array = Fill2DSummInd(row, column);

Print2DArray(array);
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
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();    
    }    
}

void Print2DArrayColor(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(array[i,j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();    
    }    
}


int row = ReadData("ВВедите количество строк");
int column = ReadData("Введите количество столбцов");
int[,] matrix = ArrayGenerator2D(row, column, 100, 10);
Print2DArrayColor(matrix);
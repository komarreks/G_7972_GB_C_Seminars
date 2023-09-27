//Считывание числа
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

int[,] ArrayGenerator2DFibo(int countRaw, int countColumn){
    Random random = new Random();

    int[,] array2D = new int[countRaw,countColumn];

    int last = 0;
    int next = 0;

    for(int i = 0; i < countRaw; i++)
        for(int j = 0; j < countColumn; j++){
            array2D[i,j] = last + next;
            last = next;
            next = next == 0 ? 1 : array2D[i,j];
        }
    return array2D;
}

void Print2DArray(int[,] array, int findNumber){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            
            if(array[i,j] == findNumber) {Console.ForegroundColor = ConsoleColor.DarkRed;}

            Console.Write(array[i,j] + "\t");

            Console.ResetColor();
        }
        Console.WriteLine();    
    }    
}

int row = ReadData("Строк");
int col = ReadData("Столбцов");

int number = ReadData("Искомая цифра");
int[,] array = ArrayGenerator2DFibo(row, col);

Print2DArray(array,number);
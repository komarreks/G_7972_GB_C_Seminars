//Считывание числа
using System.Globalization;

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

            if(i == j) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(array[i,j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();    
    }    
}

double AverageSummDiadinal(int[,] array){
    int sum = 0;
    int index = 0;

    while(index<array.GetLength(0) && index < array.GetLength(1)){
        sum = sum + array[index, index];
        index++;
    }

    index--;

    return sum/index;
}

void PrintAverageSumColumns(int[,] array){
    Console.Write("Среднее по столбцам: ");
    for(int i = 0; i < array.GetLength(0); i++){
        double average = 0.0;
        int count = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            average = average + array[i,j];
            count++;
        }
        average = average / count;

        Console.Write(average + (i < array.GetLength(0)-1 ? ", " : ""));
    }
}

int row = ReadData("Строк");
int col = ReadData("Столбцов");

int[,] array = ArrayGenerator2D(row, col, 10, 0);

Print2DArray(array);

Console.WriteLine($"Среднее арифметическое по диагонали: {AverageSummDiadinal(array)}");

PrintAverageSumColumns(array);
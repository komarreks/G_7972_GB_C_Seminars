///Считывание числа
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

//Генерация массива вещественных чисел
double[,] ArrayGenerator2DDouble(int countRaw, int countColumn){
    Random random = new Random();

    double[,] array2D = new double[countRaw,countColumn];

    for(int i = 0; i < countRaw; i++)
        for(int j = 0; j < countColumn; j++)
            array2D[i,j] = random.NextDouble()*10;
    
    return array2D;
}

//Вывод массива с раскраской
void Print2DArray(double[,] array){

    ConsoleColor[] colors = {ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, 
                            ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow, ConsoleColor.Blue,
                            ConsoleColor.Green, ConsoleColor.Yellow};

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.ForegroundColor = colors[new Random().Next(0,9)];
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();    
    }
    Console.ResetColor();   
}

int row = ReadData("Строк"); //количество строк
int col = ReadData("Столбцов"); //Количество столбцов
double[,] array = ArrayGenerator2DDouble(row, col); //Генерация массива
Print2DArray(array); // Вывод с раскраской


//Генерация массива
int[,] ArrayGenerator2D(int countRaw, int countColumn, int topBorder, int downBorder){
    Random random = new Random();

    int[,] array2D = new int[countRaw,countColumn];

    for(int i = 0; i < countRaw; i++)
        for(int j = 0; j < countColumn; j++)
            array2D[i,j] = random.Next(downBorder, topBorder);
    
    return array2D;
}

//Печать массива
void Print2DArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            if(i == j) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(array[i,j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();    
    }

    Console.WriteLine();   
}

//Проверка возможности умножения матриц
bool CanMultMatrix(int[,] mtrx1, int[,] mtrx2){
    if(mtrx1.GetLength(1) == mtrx2.GetLength(0)) return true;

    return false;
}

//Умножение матриц
int[,] MultMatrix(int[,] mtrx1, int[,] mtrx2){
    int[,] multMatrix = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];

    for(int i = 0; i < mtrx1.GetLength(0); i++){
        for(int j = 0; j < mtrx2.GetLength(1); j++){
            for (int k = 0; k < mtrx2.GetLength(0); k++)
                {
                    multMatrix[i, j] += mtrx1[i, k] * mtrx2[k, j];
                }                       
        }
        
    }
    return multMatrix;
}

//Создаем две матрицы
int[,] mtrx1 = ArrayGenerator2D(3,3,4,1);
int[,] mtrx2 = ArrayGenerator2D(3,3,4,1);

//Печатаем для контроля
Print2DArray(mtrx1);
Print2DArray(mtrx2);

//Проверяем можно ли их умножать и умножаем, затем выводим
if(CanMultMatrix(mtrx1,mtrx2)){
    int[,] resultMult = MultMatrix(mtrx1,mtrx2);
    Print2DArray(resultMult);
}


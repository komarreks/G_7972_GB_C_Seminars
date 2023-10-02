using System.Runtime.CompilerServices;

//Генерация массива
int[,] GenerateSpiralArray(int row, int col){
    int[,] newArray = new int[row,col];

    int value = 1;
    newArray[0,0] = value;

    StepRigth(newArray, value+1, 0, 1, 0, col);

    return newArray;
}

//Шаги вправо с переходом на шаги вниз
void StepRigth(int[,] array, int value, int row, int col, int min, int max){

    int curC = 0;
    for(int i = col; i<max; i++){
        array[row,i] = value;
        value++;
        curC = i;
    }
    StepDown(array, value, row+1, curC, min, max);
    
}

//Шаги вниз с переходом на шаги влево
void StepDown(int[,] array, int value, int row, int col, int min, int max){

    int curR = 0;
    for(int i = row; i<max; i++){
        array[i,col] = value;
        value++;
        curR = i;
    }
    StepLeft(array, value, curR, col-1, min, max);
}

//Шаги влево с переходом на шаги вверх
void StepLeft(int[,] array, int value, int row, int col, int min, int max){

    int curC = 0;
    for(int i = col; i>=min; i--){
        array[row,i] = value;
        value++;
        curC = i;
    }
    max--;
    min++;

     if(min<max)
         StepUp(array, value, row-1, curC, min, max);   
}

//Шаги вверх с переходом на шаги направо и смещением прямоугольника
void StepUp(int[,] array, int value, int row, int col, int min, int max){

    int curR = 0;
    for(int i = row; i>=min; i--){
        array[i,col] = value;
        value++;
        curR = i;
    }

    StepRigth(array, value, curR, col+1, min, max);    
}

//Вывод массива
void Print2DArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            if(i == j) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(array[i,j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();    
    }

    Console.WriteLine();   
}


//Инициализация спирального массива
int[,] array = GenerateSpiralArray(4,4);

//Вывод массива
Print2DArray(array);
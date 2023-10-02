//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();    
    }

    Console.WriteLine();   
}

//Поиск строки с наименьшей суммой элементов
(int,int) FindStringWithMimimalValue(int[,] mtrx){
    int number = -1;
    int value = 0;

    for(int i = 0; i < mtrx.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < mtrx.GetLength(1); j++){
            sum = sum + mtrx[i,j];
        }

        if(number == -1){
            number = i;
            value = sum;
        }else if(value > sum){
            value = sum;
            number = i;
        }
    }

    return (number, value);
    
}

int[,] mtrx = ArrayGenerator2D(6,4,10,1); //генерируется массив
Print2DArray(mtrx); //Выводится на контроль

(int number,int value) info = FindStringWithMimimalValue(mtrx); //Получаем данные строки и значения

Console.WriteLine($"Строка {info.number + 1 } имеет наименьшую сумму: {info.value}"); //Выводим
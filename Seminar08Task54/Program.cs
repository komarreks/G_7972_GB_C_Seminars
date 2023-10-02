using System.Globalization;
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Сортировка значений в строках массива
void SortStringArray(int[,] mtrx){

    for(int i = 0; i < mtrx.GetLength(0); i++){ //прохождение строк
        bool sorted = false;
        int j=1;
        bool moved = false;
        while(!sorted){ //Цикл с сортировкой, работает пока не было перемещений
            if(mtrx[i,j] > mtrx[i,j-1]){
                int buf = mtrx[i,j-1];
                mtrx[i,j-1] = mtrx[i,j];
                mtrx[i,j] = buf;
                moved = true;
            }
            j++;
            if(j == mtrx.GetLength(1)){
                j = 1;
                sorted = !moved;
                moved = false;
            } 
        }
    }
}


int[,] mtrx = ArrayGenerator2D(5,5,10,0); //Создается массив
Print2DArray(mtrx);                       //Выводится

SortStringArray(mtrx);                    //Сортируются значения в строках

Print2DArray(mtrx);                       //Выводится для контроля
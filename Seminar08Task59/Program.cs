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

    Console.WriteLine();   
}

int[] rowColumnMin(int[,] mtrx){
    int[] rcm = new int[2];
    int minValue = mtrx[0,0];

    for(int i = 0; i < mtrx.GetLength(0); i++){
        for(int j = 0; j < mtrx.GetLength(1); j++){
            if(minValue>mtrx[i,j]){
                minValue = mtrx[i,j];
                rcm[0] = i;
                rcm[1] = j;
            }            
        }            
    }
    return rcm;
} 

int[,] ArrayWithoutMinValue(int[,] mtrx, int[] rowColumnMin){
    int[,] newMtrx = new int[mtrx.GetLength(0)-1, mtrx.GetLength(1)-1];
    int indexR = 0;
    int indexC = 0;
    for(int i = 0; i < mtrx.GetLength(0); i++){
        if(i != rowColumnMin[0]){
            for(int j = 0; j < mtrx.GetLength(1); j++){
                if(j != rowColumnMin[1]){
                    newMtrx[indexR,indexC] = mtrx[i,j];
                    indexC++;
                }
            }
        }
        indexR++;
        indexC = 0;           
    }
    return newMtrx;
}

int[,] mtrx = ArrayGenerator2D(5,5,100,1);
Print2DArray(mtrx);

int[] indexesOfMinValue = rowColumnMin(mtrx);
Console.WriteLine(indexesOfMinValue[0] + ":" + indexesOfMinValue[1]);

int[,] newMtrx = ArrayWithoutMinValue(mtrx, indexesOfMinValue);

Print2DArray(newMtrx);
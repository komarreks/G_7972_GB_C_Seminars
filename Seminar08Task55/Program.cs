using System.Formats.Asn1;

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

bool TestArrayRotate(int[,] mtrx){
    if(mtrx.GetLength(0) == mtrx.GetLength(1)) return true;

    return false;
}

void ArrayRotate(int[,] mtrx){
    int buf;

    for(int i = 0; i<mtrx.GetLength(0); i++){
        for(int j = 1+i; j<mtrx.GetLength(0); j++){
            buf = mtrx[i,j];
            mtrx[i,j] = mtrx[j,i];
            mtrx[j,i] = buf;
        }
    }
}

int[,] mtrx = ArrayGenerator2D(5,5,10,0);
Print2DArray(mtrx);

if(TestArrayRotate(mtrx)) ArrayRotate(mtrx);

Print2DArray(mtrx);
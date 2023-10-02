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

Dictionary<int, int> Periodicity(int[,] mtrx){
    Dictionary<int,int> dictionary = new Dictionary<int,int>();

    for(int i = 0; i<mtrx.GetLength(0); i++){
        for(int j = 0; j<mtrx.GetLength(0); j++){
            if(dictionary.ContainsKey(mtrx[i,j])){
                dictionary[mtrx[i,j]] = dictionary[mtrx[i,j]] + 1;
            }else{
                dictionary.Add(mtrx[i,j],1);
            }
        }
    }

    return dictionary;
}

void PrintDict(Dictionary<int,int> dict){
    foreach(var value in dict){
        Console.WriteLine($"Элемент {value.Key} встречается {value.Value}");
    }
}

int[,] mtrx = ArrayGenerator2D(5,5,10,0);
Print2DArray(mtrx);

Dictionary<int, int> dict = Periodicity(mtrx);

PrintDict(dict);
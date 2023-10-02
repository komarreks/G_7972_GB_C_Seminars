//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Генерация трехмерного массива
int[,,] ArrayGenerator3D(int x, int y, int z, int min, int max, Dictionary<int,int> dict){
    
    int[,,] array3D = new int[x,y,z];

    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
            for(int k = 0; k < z; k++){                
                array3D[i,j,k] = newValue(dict, min, max);                                
            }            
    
    return array3D;
}

//Генерация уникального числа
int newValue(Dictionary<int, int> dict, int min, int max){
    Random random = new Random();
    int value = random.Next(min, max+1);
    
    while(dict.ContainsKey(value)){
        value = random.Next(min, max+1);
    }

    dict.Add(value,0);

    return value;
}

//Печать массива
void Print3DArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }   
    }
    Console.WriteLine();   
}

//Создание словаря чисел
Dictionary<int, int> dict = new Dictionary<int, int>();

//Создание массива
int[,,] array = ArrayGenerator3D(2,2,2,10,99,dict);

//Вывод массива
Print3DArray(array);
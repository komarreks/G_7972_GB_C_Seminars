//Функция чтения числа
int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

//функция с вещественными числами
int SumDigits(int num){
    int res = 0;

    while(num > 0){
        res += num % 10;
        num = num / 10;
    }

    return res;
}

//функция вычисления со строками
int SumDigitsWithStrings(int num){
    int res = 0;

    char[] numStr = num.ToString().ToCharArray();
    
    int length = numStr.Length;

    for(int i = 0; i < length; i++){
        
        res = res + (int)Char.GetNumericValue(numStr[i]);
    }

    return res;
}

//функция выведения результата
void PrintResult(string message){
    Console.WriteLine(message);
}

//Получаем число
int num = ReadData("Введите число");

//Считаем с вещественными числами
DateTime d1 = DateTime.Now;
int res1 = SumDigits(num);
PrintResult("Время выполнения с вещественными числами: "+(DateTime.Now - d1));

//Считаем со строками
DateTime d2 = DateTime.Now;
int res2 = SumDigitsWithStrings(num);
PrintResult("Время выполнения со строками: "+(DateTime.Now - d2));

//сл строками быстрее
PrintResult("Результат выполнения с вещественными числами " + res1 + " / Результат выполнения со строками " + res2);

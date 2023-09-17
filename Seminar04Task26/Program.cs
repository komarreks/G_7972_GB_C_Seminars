int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

void PrintResult(string message){
    Console.WriteLine(message);
}

int CountDigits(int num){
    int count = 0;

    while(num > 0){
        count++;
        num = num /10;
    }

    return count;
}

int num = ReadData("Введите число");
num = CountDigits(num);
PrintResult("Количество цифр: " + num);

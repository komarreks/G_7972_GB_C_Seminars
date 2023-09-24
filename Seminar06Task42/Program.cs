//Считывание числа
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

string DecToBin(int number){
    string line = string.Empty;

    while(number > 0){
        line = number%2 + line;
        number = number / 2;
    }
    
    return line;
}

int number = ReadData("ВВедите число");
Console.WriteLine(DecToBin(number));
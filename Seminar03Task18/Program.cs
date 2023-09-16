int ReadData(string message){
    Console.WriteLine(message);

    int res = int.Parse(Console.ReadLine()??"0");

    return res;
}

string WritePossibleСoordinates(int num){
    switch (num)
    {
        case 1 : return "x > 0 y > 0";
        case 2 : return "x > 0 y < 0";
        case 3 : return "x < 0 y < 0";
        case 4 : return "x < 0 y > 0"; 
        default : return "Неверная четверть";
    }
}

int quter = ReadData("Введите четверть");
Console.WriteLine(WritePossibleСoordinates(quter));
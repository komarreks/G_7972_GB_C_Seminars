int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

int QuoterTest(int x, int y){

    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return 0;
}

void PrintResult(string message){
    Console.WriteLine(message);
}

int x = ReadData("ВВедите X");
int y = ReadData("Введите Y");

int quter = QuoterTest(x,y);

PrintResult("Четверть координат: "+quter);
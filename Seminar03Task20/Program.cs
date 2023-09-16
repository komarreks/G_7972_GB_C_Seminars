int ReadData(string message){
    Console.WriteLine(message);

    int res = int.Parse(Console.ReadLine()??"0");

    return res;
}

double Calc2DDist(int x1, int x2, int y1, int y2){
    return Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
}

int x1 = ReadData("Введите x1");
int x2 = ReadData("Введите x2");
int y1 = ReadData("Введите y1");
int y2 = ReadData("Введите y2");

Console.WriteLine("Расстояние в 2D пространстве равно :"+Calc2DDist(x1,x2,y1,y2));

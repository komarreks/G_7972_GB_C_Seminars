//Считывание числа
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

//поиск точки пересечения двух прямых
double[] Point(double k1, double b1, double k2, double b2){
    double[] point = new double[2];

    point[0] = (b1-b2)/(k2-k1);
    point[1] = k1*point[0]+b1;

    return point;
}

double k1 = ReadData("Введите k1");
double b1 = ReadData("Введите b1");

double k2 = ReadData("Введите k2");
double b2 = ReadData("Введите b2");

int k3 = ReadData("Введите k3");
int b3 = ReadData("Введите b3");

double[] point1 = Point(k1, b1, k2, b2);
double[] point2 = Point(k1, b1, k3, b3);
double[] point3 = Point(k2, b2, k3, b3);

Console.WriteLine("координаты пересечения линии 1 и линии 2" + point1[0] + " " + point1[1]);
Console.WriteLine("координаты пересечения линии 1 и линии 3" + point2[0] + " " + point2[1]);
Console.WriteLine("координаты пересечения линии 2 и линии 3" + point3[0] + " " + point3[1]);
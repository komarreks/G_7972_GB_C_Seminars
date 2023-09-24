//Считывание числа
int ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"0");

    return point;
}

Boolean TrinangleTest(int a, int b, int c){
    return a+b>c && a+c>b && b+c>a;
}

Console.WriteLine("Введите стороны треугольника");
int a = ReadData("");
int b = ReadData("");
int c = ReadData("");

if(TrinangleTest(a,b,c)) {
    Console.WriteLine("Треугольник чуществует");
}else{Console.WriteLine("Треуготльник не существует");}
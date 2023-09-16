int[] LoadPoint(string message){
    Console.WriteLine(message);

    int[] points = new int[3];

    for(int i = 0; i<3; i++){
        points[i] = int.Parse(Console.ReadLine()??"0");
    }

    return points;
}

double Calc3DDist(int[] point1, int[] point2){

    return Math.Sqrt(
        Math.Pow((point1[0]-point2[0]),2)+
        Math.Pow((point1[1]-point2[1]),2)+
        Math.Pow((point1[2]-point2[2]),2)
    ); 

}

int[] point1 = LoadPoint("Введите координаты первой точки");
int[] point2 = LoadPoint("Введите координаты второй точки");

Console.WriteLine("Расстояние между точками в 3д пространстве: " + Calc3DDist(point1, point2));
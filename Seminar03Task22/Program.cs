int ReadData(string message){
    Console.WriteLine(message);

    int res = int.Parse(Console.ReadLine()??"0");

    return res;
}

string TableDegree(int num, int degree){
    string result = string.Empty;
    for(int i = 1; i<=num; i++){
        result = result + Math.Pow(i,degree)+ " ";
    }

    return result;
}

int num = ReadData("Введите число:");

Console.WriteLine(TableDegree(num, 2));
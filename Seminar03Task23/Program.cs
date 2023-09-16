int ReadData(string message){
    Console.WriteLine(message);

    int res = int.Parse(Console.ReadLine()??"0");

    return res;
}

string stringSpaseAdd(int num){
    string res = string.Empty;

    string numStr = num.ToString();

    int iterator = 5 - numStr.Length;

    for(byte i = 1; i<= iterator; i++){
        res = res + " ";
    }

    return res+numStr;

}

string TableDegree(int num, int degree){
    string result = string.Empty;
    for(int i = 1; i<=num; i++){
        
        Console.Write(stringSpaseAdd(i));
        result = result + stringSpaseAdd((int)Math.Pow(i,degree));
    }

    Console.WriteLine();
    return result;
}

int num = ReadData("Введите число");

string result = TableDegree(num, 3);

Console.Write(result);
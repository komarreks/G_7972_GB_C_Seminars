using System.Numerics;

int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

void PrintResult(string message){
    Console.WriteLine(message);
}

BigInteger Factorial(int num){
    BigInteger res = 1;

    for(int i = 2; i <= num; i++){
        res = res * i;
    }

    return res;
}
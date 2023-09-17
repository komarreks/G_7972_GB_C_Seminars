int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

void PrintResult(string message){
    Console.WriteLine(message);
}

int SimpleSum(int numA){
    int sum = 0;

    for(int i = 1; i<=numA; i++){
        sum += i;
    }

    return sum;
}

int GausseSum(int n){
    return (n*(n+1))/2;
}

int numberA = ReadData("Введите число");

//numberA = SimpleSum(numberA);
numberA = GausseSum(numberA);

PrintResult("Сумма равна: " + numberA);

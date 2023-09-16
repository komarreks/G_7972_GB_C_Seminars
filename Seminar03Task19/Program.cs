int ReadData(string message){
    Console.WriteLine(message);

    int res = int.Parse(Console.ReadLine()??"0");

    return res;
}

bool isPolinome(int num){
    char[] num1Array = num.ToString().ToCharArray();
    char[] num2Array = num.ToString().ToCharArray();

    Array.Reverse(num2Array);

    string num1 = new string(num1Array);
    string num2 = new string(num2Array);

    if(num1.Equals(num2)){
        return true;
    }

    return false;
}

bool fiveDigit(int num){
    if (num > 9999 && num < 100000)
    {
        return true;
    }

    return false;
}

int num = ReadData("Введите число");

if(fiveDigit(num)){
    if(isPolinome(num)){
        Console.WriteLine("Является полиномом");
    }else{
        Console.WriteLine("Не является полиномом");
    }
}else{
    Console.WriteLine("Число не пятизначное");
}

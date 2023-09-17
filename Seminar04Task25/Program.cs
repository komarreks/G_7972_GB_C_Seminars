using System.Numerics; //Подключаем биг интеджер

//Функция чтения числа
int ReadData(string message){
    Console.WriteLine(message);

    int point = int.Parse(Console.ReadLine()??"1");

    return point;
}

//функция выведения результата
void PrintResult(string message){
    Console.WriteLine(message);
}

//Сумма
void Sum(int numA, int NumB){
    PrintResult("Сумма: "+ (numA + NumB));
}

//Деление
void Div(int numA, int NumB){
    double res = (float)numA / (float)NumB;
    PrintResult("Результат деления: " + res);
}

//Разность
void Sub(int numA, int NumB){
    PrintResult("Разность: "+ (numA - NumB));
}

//Произведение
void Mult(int numA, int NumB){
    PrintResult("Умножение: "+ (numA + NumB));
}

//Степень
void Pow(int numA, int NumB){
    PrintResult("Результат степени: "+ (BigInteger)Math.Pow(numA, NumB));
}

//функция считывания действия из консоли
string EnterAction(string message){
    Console.WriteLine(message);

    string action = string.Empty;
    action = Console.ReadLine()??"";

    if(action.Equals("+") || action.Equals("-") || action.Equals("/") || action.Equals("*") || action.Equals("**") || action.Equals("q")){
        return action;
    }else{
        PrintResult("действие указано неверно");
        action = EnterAction("Введите внимательно действие");        
    }

    return action;
}

//объявляем экшн пустым сразу
string action = "";

//выводим заголовок программы
PrintResult("Консольный калькулятор, введите два числа и действия (+-*/), для возведения в степень '**', для выхода введите 'q'");

//даем работать с калькулятором пока не надоест, чтобы не запускать постоянно, ожидаем тригер завершения программы
while(true){
    //считываем действие
    action = EnterAction("Введите действие ('+' '-' '/' '*' '**' 'q')");
    //сразу смотрим, не хочетли пользователь завершить работу
    if(action.Equals("q")) break;
    //Считываем числа
    int numA = ReadData("Введите первое число: ");
    int numB = ReadData("Введите второе число: ");    
    //выполняем действия в зависимости от экшна
    if(action.Equals("+")) Sum(numA, numB);
    if(action.Equals("-")) Sub(numA, numB);
    if(action.Equals("*")) Mult(numA, numB);
    if(action.Equals("/")) Div(numA, numB);
    if(action.Equals("**")) Pow(numA, numB);
}
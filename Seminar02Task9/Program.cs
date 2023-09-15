// выводит случайное число из отрезка 10-99
// и показывает наибольшую цифру этого числа
void Variant1(){
    Console.WriteLine("способ 1");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number/10;
    int secondDigit = number%10;

    if(firstDigit > secondDigit){
        Console.WriteLine(firstDigit);
    }else{
        Console.WriteLine(secondDigit);
    }
}

void Variant2(){
    Console.WriteLine("способ 2");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    Console.WriteLine(number/10 > number%10 ? number/10 : number%10);
}

void Variant3(){
    Console.WriteLine("способ 1");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    char[] digitChar = number.ToString().ToCharArray();

    Console.WriteLine((int)digitChar[0] > (int)digitChar[1] ? digitChar[0] : digitChar[1]);
}

Variant1();
Variant2();
Variant3();
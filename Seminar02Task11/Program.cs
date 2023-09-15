void Variant1(){
    int number = new Random().Next(100,1000);

    Console.WriteLine(number);

    int firstGigit = number / 100;
    int lastDigit = number % 10;

    number = firstGigit * 100 + lastDigit;

    Console.WriteLine(number);
}

Variant1();

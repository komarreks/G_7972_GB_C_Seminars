int num = int.Parse(Console.ReadLine()??"0");

if (num > 99 && num < 1000){
    Console.WriteLine("Последняя цифра числа: " + num % 10);
}else{
    Console.WriteLine("Это не трехзначное число");
}
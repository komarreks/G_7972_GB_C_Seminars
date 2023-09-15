//обернем в функцию, чтобы стало красивее
int Finder(int num){
    //делим на 10 пока не станет трехначным числом
    while(num > 999){
        num = num / 10;
    }

    //Выведем третью цифру как остаток от деления на 10
    int digit = num % 10;

    return digit;    
}

// получаем число
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()??"0");

//проверям трехзначное оно или больше, если нет - выводим ошибку
if(num > 99){
   Console.WriteLine(Finder(num)); 
} else{
    Console.WriteLine("Число не трехзначное");
}

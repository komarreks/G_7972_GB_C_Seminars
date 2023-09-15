Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine()??"0");

if(num % 7 == 0 && num % 23 == 0){
    Console.WriteLine("Кратно и 7 и 23");
}else{
    Console.WriteLine("не кратно и 7 и 23");
}


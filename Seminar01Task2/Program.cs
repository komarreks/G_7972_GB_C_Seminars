Console.WriteLine("Введите первое число");

int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");

int num2 = int.Parse(Console.ReadLine()??"0");

if(num1 > num2){
    Console.WriteLine("Первое число больше");
}else if(num1 < num2){
    Console.WriteLine("Второе число больше");
}else{
    Console.WriteLine("Числа равны");
}
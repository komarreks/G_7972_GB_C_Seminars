Console.WriteLine("Введите два числа");

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

if(num2 % num1 == 0){
    Console.Write("Второе число кратно первому");
}else{
    Console.WriteLine("Второе число не кратно первому, остаток от деления: " + num2 % num1);
}

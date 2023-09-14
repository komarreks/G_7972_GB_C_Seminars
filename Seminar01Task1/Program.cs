int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

if(num1*num1 == num2){
    Console.WriteLine("Второе число является квадратом первого");
}else{
    Console.WriteLine("Второе число не является квадратом первого");
}
Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine()??"0");

if(num % 2 == 0){
    Console.WriteLine("Число четное");    
}else{
    Console.WriteLine("Число не четное");
}

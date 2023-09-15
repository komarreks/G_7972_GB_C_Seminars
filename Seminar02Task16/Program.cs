Console.WriteLine("Введите два числа");

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

int max = num1 > num2 ? num1 : num2;
num2 = num1 - max == 0 ? num2 : num1;

if(num2 * num2 == max){
    Console.WriteLine("Число: "+ max + " является квадратом числа " + num2);
}else{
    Console.WriteLine("Числа не являются квадратами друг друга");
}

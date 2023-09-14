Console.WriteLine("Введите число: ");

string? inputNum = Console.ReadLine(); //проверка на null или можно после инструкции написать ??"0", если будет null - заменится на ноль

if (inputNum != null){
    int num = int.Parse(inputNum); // преобразование типа
    int result = num * num;

    Console.WriteLine("Квадрат числа равен " + result);

    //еще можно использовать такое
    Console.WriteLine("Квадрат числа равен " + Math.Pow(int.Parse(inputNum), 2));    
}
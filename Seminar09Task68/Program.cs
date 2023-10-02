//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Считывание данных
long ReadData(string message){
    if(!(message == "")) Console.WriteLine(message);

    long point = (long)int.Parse(Console.ReadLine()??"0");

    return point;
}

//Функция Акермана
long Akerman(long n, long m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akerman(n - 1, 1);
    else
      return Akerman(n - 1, Akerman(n, m - 1));
}

//Считываем значения m и n функции
long m = ReadData("Значение М");
long n = ReadData("Значение N");

//Выводим результат вычислений
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akerman(m,n)}");
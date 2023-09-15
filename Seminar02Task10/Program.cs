// получаем число трехначное
Console.WriteLine("Введите число");
//считываем, если null - меняем на 100
string num = Console.ReadLine()??"100";
//преобразуем в массив символов
char[] charNumArray = num.ToCharArray();
//выводим вторую цифру
Console.WriteLine("Вторая цифра - " + charNumArray[1]);



int dayOfWeek = int.Parse(Console.ReadLine()??"-1");

string[] daysOfWeek = new string[7];

daysOfWeek[0] = "Понедельник";
daysOfWeek[1] = "Вторник";
daysOfWeek[2] = "Среда";
daysOfWeek[3] = "Четверг";
daysOfWeek[4] = "Пятница";
daysOfWeek[5] = "Суббота";
daysOfWeek[6] = "Воскресение";

if (dayOfWeek <= -1 || dayOfWeek > 7)
{
    Console.WriteLine("Такого дня не существует");
}else
{
    Console.WriteLine(daysOfWeek[dayOfWeek-1]);
}
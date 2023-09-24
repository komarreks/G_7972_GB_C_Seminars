//Ввод символов в консоли
using System.Text.RegularExpressions;

string ReadData(){
    Console.WriteLine("Введите последовательость символов");

    return Console.ReadLine()??"";
}

//подсчет всего символов и цифр
void Calculate(string line){
    Regex regex = new Regex(@"\d");

    Console.WriteLine("Введено " + line.Length);

    MatchCollection matchCollection = regex.Matches(line);

    Console.WriteLine("Количество цифр больше нуля "+ matchCollection.Count);
}

string line = ReadData();
Calculate(line);
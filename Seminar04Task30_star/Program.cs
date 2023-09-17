//Получаем массив участников
string[] GetArray(){
    Console.WriteLine("Напишите участников вечеринки");

    string line = Console.ReadLine()??"";
     
    return line.Split(" ");        
}

//Делаем выбор
void WhoGoToBeer(string[] arr){
    Random random = new Random();
    
    string str = arr[random.Next(0, arr.Length)];
    Console.WriteLine("Отправляется " + str);
}

string[] arr = GetArray();
WhoGoToBeer(arr);
// создание словаря уберем в функцию
Dictionary<byte, string> Dict(){
    var dictionary = new Dictionary<byte, string>(){
        {1, "Нет"},
        {2, "Нет"},
        {3, "Нет"},
        {4, "Нет"},
        {5, "Нет"},
        {6, "Да"},
        {7, "Да"},
    };

    return dictionary;
}

// получаем день недели
Console.WriteLine("Введите день недели");
byte numberDay = byte.Parse(Console.ReadLine()??"0");

var dictionary = Dict(); //получаем словарь

//проверим день недели это или ошибка
if(numberDay > 1 && numberDay < 8){
    Console.WriteLine(dictionary[numberDay]); //получаем выходной день или нет из словаря
}else{
    Console.WriteLine("Такого дня недели не существует");//укажем на ошибку неверного ввода дня
}

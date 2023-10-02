Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine()??"0");

int i = 1;

while(i <= num){
    if(i % 2 == 0){
       string comma = i + 2 <= num ? ", " : "";
       Console.Write(i + comma); 
    }
    i++;
}

Console.WriteLine("Введите три числа");

int[] numArray = new int[3];

int index = 0;
while (index < numArray.Length){
    numArray[index] = int.Parse(Console.ReadLine()??"0");
    index++;
}

int max = numArray[0];

index = 1;

while (index < numArray.Length){
    if (numArray[index] > max){
        max = numArray[index];
    }
    index++;
}

Console.WriteLine("Максимальное число: " + max);

int N = int.Parse(Console.ReadLine()??"0");

int evN = N*-1;

while (evN < N){
    Console.Write(evN + ", ");
    evN++;
}

Console.Write(evN);
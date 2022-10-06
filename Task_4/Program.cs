// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int res = 1;
while(res < N){
    if((res % 2) == 0){
        Console.Write($"{res}, ");
    }
    res++;}
Console.Write($"Четные числа от 1 до {N}.");
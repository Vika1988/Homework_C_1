// Напишите программу, которая на вход принмает два числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if(a>b)
{
    Console.WriteLine($"Число {a} больше числа {b} ");
} 
else
{
    Console.WriteLine($"Число {b} больше числа {a} ");
}

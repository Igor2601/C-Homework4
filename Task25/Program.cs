// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Число B: ");
int b = int.Parse(Console.ReadLine());
int Power(int a, int b)
{
    int result = a;
    for(int i = 1; i<b;i++)
   result = result*a;
   return result;
}
Console.WriteLine($"A в степени B -> {Power(a,b)}");
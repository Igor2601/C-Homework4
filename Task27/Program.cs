// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int result = 0;
int Summa(int n,int result)
{
if (n<100)
result = n/10 + n%10;   
if (n>=100 && n<1000)
result = (n/100) + (n%100/10) + (n%10);
if (n>=1000 && n<10000)
result = (n/1000) + (n%1000/100) + (n%100/10) + (n%10);
return result;
}
Console.WriteLine($"Сумма цифр в числе -> {Summa(n,result)}");
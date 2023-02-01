// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.Write("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
if ( num <=99 || 1000<=num)
{
 Console.ForegroundColor = ConsoleColor.Red;
 Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
 Console.ForegroundColor = ConsoleColor.Green;
 string Num = Convert.ToString(num);   
 Console.WriteLine("вторая цифра этого числа -> "+ Num[1]);
}
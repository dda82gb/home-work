// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число :");
int num = int.Parse(Console.ReadLine());
if ( num <=99 )
{
 Console.BackgroundColor = ConsoleColor.Red;
 Console.WriteLine("->Tретьей цифры нет");
}
else
{
 Console.ForegroundColor = ConsoleColor.Green;
 string Num = Convert.ToString(num); 
 Console.WriteLine("Третья цифра этого числа-->"+Num[2]);
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine("Ураа! это точно "+Num[2]);
}
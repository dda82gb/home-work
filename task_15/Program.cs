// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int Day = int.Parse(Console.ReadLine());
void Week(int Day) 
{
  if (Day == 6 || Day == 7)
  {
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("(этот день выходной) -> да");
  }
  else if (Day < 1 ||Day > 7) 
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("это вообще не день недели");
  }
 
  else 
  { Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("(этот день не выходной) -> нет");
}    
}
 Week(Day);
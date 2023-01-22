// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите 5-значное число");
string num = Console.ReadLine();
if(num.Length == 5)
{
  if(num[0] == num[4] && num[1] == num[3]) System.Console.WriteLine("Да");
  else System.Console.WriteLine("Нет");
}
else System.Console.WriteLine("Введено не верное значение");
//Seminar1 - ДОМАШНЕЕ ЗАДАНИЕ НИЖЕ

//Задача 1.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 ==  quad2)
{
  Console.WriteLine("Yes");
}
else
{
 Console.WriteLine("No");
}
*/
//Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.WriteLine(" Input a posistive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;
while(current <= number)
{
  Console.Write(current + " ");
  current++;// current = current + 1; or Current +=b
}
//32143 / 10 = 3214
// 32143 / 100 = 321
// 32143 / 1000 = 32
// 32143 / 10000 = 3

// 32143 % 10 = 3
// 32143 % 100 = 43 
// 32143 % 1000 = 143
// 32143 % 10000 = 2143
*/



/* ДОМАШНАЯЯ РАБОТА 
1 ЗАДАЧА
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
РЕШЕНИЕ
Console.Write("input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int min = 0;
int max = 0;
if(num1 < num2)
{
  min = num1;
  max = num2;
  Console.WriteLine(min + " = min; " + max + " = max ");
}
else
{
  min = num2;
  max = num1;
  Console.WriteLine(min + " = min; " + max + " = max ");
}
*/
/* 2 ЗАДАЧА
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a 3nd number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maximum = 0;

if(num1 > maximum)
{
 maximum = num1;
}
if(num2 > maximum)
{
maximum = num2;  
}
if(num3 > maximum)
{
maximum = num3;
}
Console.WriteLine(maximum + " = maximum");
*/
/* 3 ЗАДАЧА
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int even = number %2;
if(even ==0)
{
  Console.WriteLine("Четное");
}
else
{
  Console.WriteLine("Нечетное");
}
*/
/* 4 ЗАДАЧА
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int even = 2;
if(number >1)
{
  while(even <= number)
  {
    Console.WriteLine(" " + even);
    even = even +2;
  }
}









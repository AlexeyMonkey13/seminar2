// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6

// ПОЛУЧИЛОСЬ ТОЛЬКО ТАК

Console.WriteLine("введите число " );

int number = Convert.ToInt32(Console.ReadLine());
int n = number;

if (-100 > n && n > -1000)
{
    Console.WriteLine(n % 10); 
}
if (-1000 > n && n > -10000)
{
    Console.WriteLine(n / 10 % 10);
}
if (-10000 > n && n > -100000)
{
    Console.WriteLine(n / 100 % 10);
}if (-100000 > n && n > -1000000)
{
    Console.WriteLine(n / 1000 % 10);
}if (-1000000 > n && n > -10000000)
{
    Console.WriteLine(n / 10000 % 10);
}if (-10000000 > n && n > -100000000)
{
    Console.WriteLine(n / 100000 % 10);
}

if (100 < n && n < 1000)
{
    Console.WriteLine(n % 10);
   
}
else
{
    Console.WriteLine("третьей цифры нет ");
}

if (1000 < n && n < 10000)
{
    Console.WriteLine(n / 10 % 10);
}
if (10000 < n && n < 100000)
{
    Console.WriteLine(n / 100 % 10);
}if (100000 < n && n < 1000000)
{
    Console.WriteLine(n / 1000 % 10);
}if (1000000 < n && n < 10000000)
{
    Console.WriteLine(n / 10000 % 10);
}if (10000000 < n && n < 100000000)
{
    Console.WriteLine(n / 100000 % 10);
}


Console.WriteLine("введите число " );

int number = Convert.ToInt32(Console.ReadLine());
int numberb = number + 1;
if (number % 7 == 0)
{
    Console.WriteLine("выходной ");
}
if (numberb % 7 == 0)
{
    Console.WriteLine("выходной ");
    
}

if (number % 7 !=0)
{
    Console.WriteLine("Работать !!! ");
}


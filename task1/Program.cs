// написать программу которая принимает на вход трехзначное число и выводит вторую цифру

Console.WriteLine("введите трехзначное число " );

int number = Convert.ToInt32(Console.ReadLine());
int a = number;
int d = 99;
int c = 1000;

    
if ( d < a && a < c)
{
    Console.WriteLine((a/10) % 10);
    
}

else
{
    Console.WriteLine("false ");
}



//int n = (number / 10) % 10 ;
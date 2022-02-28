Console.WriteLine("Задача 1");
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32 (Console.ReadLine());

if (a == b)
{
Console.WriteLine(" Числа равны ");
}
 else
 {
if (a > b)
{
     Console.WriteLine("Большее число - " + a );
     Console.WriteLine("Меньшее число - " + b );
}
else
{
     Console.WriteLine("Большее число - " + b);
     Console.WriteLine("Меньшее число - " + a);
}
}

Console.WriteLine("Задача 2");

Console.WriteLine("Введите число 1");
int c = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число 2");
int d = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число 3");
int e = Convert.ToInt32 (Console.ReadLine());

int max;
if (c > d)
{
    max = c;

}
 else
 {
    max = d;

}

if (e > max)
{
    max = e;

}

Console.WriteLine("Максимальное число - " + (max));

Console.WriteLine("Задача 3");

Console.WriteLine("Введите значение N");

int N = Convert.ToInt32 (Console.ReadLine());
string F = "";
for (int m = 1; m <= N; m++)
{
    if ( m%2 == 0)
    {
     F = F + ", " + m;

    }
}
    F = F.Substring(2);

    Console.WriteLine(F);


Console.WriteLine( "Задача 4");

Console.WriteLine("Введите число ");
int X = Convert.ToInt32 (Console.ReadLine());


if ( X%2 == 0)
 
 {

Console.WriteLine( X + "- чётное число");

 }

 else 
 {
     Console.WriteLine( X + "- нечётное число");
 }

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


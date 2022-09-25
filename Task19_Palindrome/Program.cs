// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());


if (n > 9999 & n < 100000)
{
    if (n % 10 == n / 10000 & n / 10 % 10 == n / 1000 % 10)
    {
        Console.WriteLine($"Число {n} палиндром");
    }
    else 
    {
        Console.WriteLine($"Число {n} не палиндром"); 
    }
}
else
{
  Console.WriteLine("Вы ввели не пятизначное число"); 
}


/*Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintCountdown(number, count);


void PrintCountdown(int n, int count)
{
    if(n>0)
    {
        if (count > n)
        {
            return;
        }
        else
        {
            PrintCountdown(n, count + 1);
            Console.Write(count + " ");
        }
    }
    else
    {
        Console.WriteLine("Введены значения меньше единицы!");
    }
}
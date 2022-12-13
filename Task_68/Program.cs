/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

FunctionAkkerman(m,n);

void FunctionAkkerman(int m, int n)
{
    Console.Write(Function(m, n)); 
}

int Function(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Function(m - 1, 1);
    }
    else
    {
        return (Function(m - 1, Function(m, n - 1)));
    }
}
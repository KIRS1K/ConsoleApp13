



using System;

public interface Calculator
{
    public int a(int f, int b);
}

public class calcu : Calculator
{
    public int a(int f, int b) 
    {
        int gi = f + b;
        return gi;
    }
}

public class prog
{
    public static void Main(string[] args)
    {
        var mc = new calcu();
        double result = 0;
        try
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            result = mc.a(num2, num1);
            Console.WriteLine($"Результат: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено некорректное значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Операция завершена.");
        }
    }
}
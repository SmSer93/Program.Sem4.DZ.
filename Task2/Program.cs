// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16



Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Введены не корректные данные");
}

if (n >= 0)
{
    int num_n = 1;
    {

        for (int i = 0; i < n; i++)
        {
            num_n *= num;
        }
    }
    Console.WriteLine(num_n);
}

return 0;
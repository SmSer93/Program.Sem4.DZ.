// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите любое целое число: ");

int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
do
{
    sum = sum + number % 10;
    number = number / 10;
}
while (number > 0);
void Amount()
{
    Console.WriteLine($"Сумма цифр = {sum}");
}
Amount();

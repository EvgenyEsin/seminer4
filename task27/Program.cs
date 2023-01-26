// Напишите программу, которая принимает на вход число
// и выдает сумму цифр в числе (через int)
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa (int temp)
{
    int sum = 0; // Переменная для суммы
    while (temp > 0)
    {
        sum = sum + (temp % 10); // Прибавляем к сумме последнюю цифру числа
        temp /=10; // Сокращаем наше число (убираем один знак справа)
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num +" -> " + Summa(num));
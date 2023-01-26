// 25. Напишите цикл, который принимает на вход два числа (А и В)
// и возвращает число А в натуральную степень В
// 3, 5 -> 243 (3 в 5 )
// 2, 4 -> 16

// Вариент 1 с использованием цикла for
int Stepen (int numberA, int numberB)
{
    int result = 1;
    if (numberB == 0) return result;
    else 
    {
        for (int i = 1; i <= numberB; i++)
            result = result * numberA;
    }
    return result;
}

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень его возвести?: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{numberA} в степени {numberB} равно {Stepen(numberA, numberB)}");


// Вариант 2 с использованием цикла while
int Stepen2 (int numA, int numB)
{
    int res = 1;
    if (numB == 0) return res;
    else 
    {
        int count = 1;
        while (count <= numB)
        {
            res = res * numA;
            count ++;
        }
            
    }
    return res;
}

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень его возвести?: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{numA} в степени {numB} равно {Stepen2(numA, numB)}");
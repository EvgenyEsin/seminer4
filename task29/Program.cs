// 29 Напишите программу, которая задает массив из 8 элементов
// и выводит их на экран

string CreateRandomArray ()
{
    int [] array = new int [8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 20);
        Console.Write(array[i] + ", ");
    }
    return "\b\b ";
}
Console.Write(CreateRandomArray ());

// Вариант2* Напишите программу, которая задает массив из N элементов
// в заданном пользователем диапазоне и выводит их на экран

string CreateRandomArray2 (int numElement, int diap)
{
    int [] array2 = new int [numElement];
    for (int i = 0; i < numElement; i++)
    {
        array2[i] = new Random().Next(0, (diap + 1));
        Console.Write(array2[i] + ", ");
    }
    return "\b\b ";
}

Console.WriteLine("Сколько элементов в массиве?: ");
int numElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение элемента (не больше 20)?: ");
int diap = Convert.ToInt32(Console.ReadLine());
Console.Write(CreateRandomArray2(numElement, diap));
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Promt(string? message)
{
    System.Console.Write(message + " -> ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(string msg)
{
    int size = Promt("Введите число, длину массива ");
    int[] array = new int[size];
    return array;
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt("Введите число ");
    }
    return array;
}

void CheckArray(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine("Количество чисел больше 0 = " + count);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + ";");
    }
}

int [] myArray = CreateArray("");

FillArray(myArray);
System.Console.WriteLine("В заданном массиве: ");
PrintArray(myArray);
System.Console.WriteLine();
CheckArray(myArray);
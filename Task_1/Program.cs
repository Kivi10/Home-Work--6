// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Promt(string? message)
{
    System.Console.Write(message + " -> ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int num1, int num2, int num3, int num4)
{
    int[] array = new int[4];
    array[0] = num1;
    array[1] = num2;
    array[2] = num3;
    array[3] = num4;
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

int num1 = Promt("Введите число 1 ");
int num2 = Promt("Введите число 2 ");
int num3 = Promt("Введите число 3 ");
int num4 = Promt("Введите число 4 ");

int[] myArray = CreateArray(num1, num2, num3, num4);

CheckArray(myArray);
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Promt(string? message)
{
    System.Console.Write(message + " -> ");
    return double.Parse(Console.ReadLine());
}

double CalculateX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CalculateY(double b1, double b2, double k1, double k2)
{
    double y = k1 * CalculateX(b1, b2,k1,k2) + b1;
    return y;
}

double b1 = Promt("Введите число b1");
double b2 = Promt("Введите число b2");
double k1 = Promt("Введите число k1");
double k2 = Promt("Введите число k2");

double x = CalculateX(b1, b2, k1, k2);
double y = CalculateY(b1, b2, k1, k2);

System.Console.WriteLine($"Точка пересечения прямых ({x},{y})");

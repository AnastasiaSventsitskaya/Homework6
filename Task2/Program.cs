// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Write b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Write k1: ");
Double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Write b2: ");
Double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Write k2: ");
Double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    double x = 0;
    double y = 0;

    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine("Точка пересечения: "+x +"," +y );
}

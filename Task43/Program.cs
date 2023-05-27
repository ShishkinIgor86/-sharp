//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void pp(double[] coord)
{
    if (coord[0]==coord[2])
    {
        Console.WriteLine("Прямые параллельны, точек пересения нет");
    }
    else
    {
        double x=(coord[3]-coord[1])/(coord[0]-coord[2]);
        double y=coord[0]*x+coord[1];
        Console.WriteLine($"({x},{y})");
    }
}
Console.WriteLine("Введите коэффициенты k1,b1,k2,b2 через запятую: ");
double[] coord=Console.ReadLine().Split(',').Select(double.Parse).ToArray();
Console.Write($"b1={coord[1]},k1={coord[0]},b2={coord[3]},k2={coord[2]}->");
pp(coord);
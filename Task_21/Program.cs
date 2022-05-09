// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D-пространстве
// A (3, 6, 8); B(2, 1, -7) -> 15,84
// A(7, -5, 0); B(1, -1, 9) -> 11,53

double xA = Coordinate("x", "A");
double yA = Coordinate("y", "A");
double zA = Coordinate("z", "A");
double xB = Coordinate("x", "B");
double yB = Coordinate("y", "B");
double zB = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double a = (xB - xA)*(xB - xA);
double b = (yB - yA)*(yB - yA);
double c = (zB - zA)*(zB - zA);

double d = a + b + c;
double gip = Distance(d);

double Distance(double sum)
{
    return Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками равно {gip}");


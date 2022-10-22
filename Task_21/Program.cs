double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double ac = x2 - x1;
    double bc = y2 - y1;
    double zc = z2 - z1;
    double dist = Math.Sqrt(ac * ac + bc * bc + zc * zc);
    return dist;
}

Console.WriteLine("Input first point x coordinate: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input first point y coordinate: ");
double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input first point z coordinate: ");
double c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second point x coordinate: ");
double d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second point y coordinate: ");
double  e = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second point z coordinate: ");
double f = Convert.ToInt32(Console.ReadLine());

double res = Distance(a, b, c, d, e, f);

Console.WriteLine($"The length of the segment is {res}");
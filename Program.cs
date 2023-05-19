//uc1-calculate length
int x1, x2, y1, y2;
double length;
Console.WriteLine("---Calculate length of Line---");
Console.WriteLine("Enter X1 value");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y1 value");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X2 value");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y2 value");
y2 = Convert.ToInt32(Console.ReadLine());
length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Length of line is-" + length);


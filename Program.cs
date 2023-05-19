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


//UC2-- two lines are the equal
int x1,y1,x2,y2, z1,a1,z2,a2;
double length1,length2;

Console.WriteLine("Enter the Co ordinates of First Line");
Console.WriteLine("Enter X1 Value");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y1 Value");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X2 Value");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y2 Value");
y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Co ordinates of Second Line");
Console.WriteLine("Enter Z1 Value");
z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter A1 Value");
a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z2 Value");
z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter A2 Value");
a2 = Convert.ToInt32(Console.ReadLine());

length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
length2 = Math.Sqrt(Math.Pow(z2 - z1, 2) + Math.Pow(a2 - a1, 2));
Console.WriteLine("Length of the First Line is--" + length1);
Console.WriteLine("Length of the Second Line is--" + length2);

if(length1.Equals(length2))
{
    Console.WriteLine("Both Line Lengths are Equal");
}
else
{
    Console.WriteLine("Not Equal");
}


//UC3-- Comparing two lines are the equal or Greater or Less
int a1, b1, a2, b2, c1, d1, c2, d2;
double length1, length2;

Console.WriteLine("Enter the Co ordinates of First Line");
Console.WriteLine("Enter A1 Value");
a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B1 Value");
b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter A2 Value");
a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B2 Value");
b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Co ordinates of Second Line");
Console.WriteLine("Enter C1 Value");
c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter D1 Value");
d1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter C2 Value");
c2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter D2 Value");
d2 = Convert.ToInt32(Console.ReadLine());

length1 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
length2 = Math.Sqrt(Math.Pow(c2 - c1, 2) + Math.Pow(d2 - d1, 2));
Console.WriteLine("Length of the First Line is--" + length1);
Console.WriteLine("Length of the Second Line is--" + length2);

if (length1.Equals(length2))
{
    Console.WriteLine("Both Line Lengths are Equal");
}
else
{
    Console.WriteLine("Not Equal");
}


switch (length1.CompareTo(length2))
{
    case 1:
        Console.WriteLine("First Line is Greater than Second Line");
        break;

    case -1:
        Console.WriteLine("First Line is Less than Second Line");
        break;
    default:
        Console.WriteLine("Both Lines are Equal");
        break;

}

        }
    }
}


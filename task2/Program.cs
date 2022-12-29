Console.Clear();
Console.WriteLine("Задайте значениt b1: ");
double b1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значениt k1: ");
double k1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значениt b2: ");
double b2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значениt k2: ");
double k2= Convert.ToInt32(Console.ReadLine());

double x=(-b1+b2)/(-k1+k2);
double y= k2 *x +b2;

Console.WriteLine($"пересечение в (.) с координатами х:{x} и у:{y}");


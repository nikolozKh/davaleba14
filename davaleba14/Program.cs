using davaleba14;

Console.WriteLine("Temperature Example:");

Temperature t = new Temperature(25);
Fahrenheit f = t;
double celsiusVal = (double)t;

Console.WriteLine(t);
Console.WriteLine(f); 
Console.WriteLine($"Double celsius: {celsiusVal}");


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
/////////////////////////////////////////

Console.WriteLine("Box Example:");
Box b1 = new Box(10);
Box b2 = new Box(15);
Box b3 = b1 + b2;
Box b4 = b2 - b1;


Console.WriteLine(b3);
Console.WriteLine(b4);
Console.WriteLine($"b1 == b2: {b1 == b2}");
Console.WriteLine($"b2 > b1: {b2 > b1}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

///////////////////////////////////////////

Console.WriteLine("BoxCollection Example:");
BoxCollection collection = new BoxCollection(3);
collection[0] = new Box(5);
collection[1] = new Box(10);
collection[2] = new Box(15);

for (int i = 0; i < collection.Length; i++)
{
    Console.WriteLine($"Box {i}: {collection[i]}");
}
    

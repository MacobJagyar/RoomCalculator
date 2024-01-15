double length, width;

do
{
    Console.Clear();
    Console.Write("Please enter the length: ");
    if (!double.TryParse(Console.ReadLine(), out length))
    {
        Console.WriteLine("___\n\nNot a number, please try again.");
        Task.Delay(2000).Wait();
    }
} while (length == 0);

Console.Clear();

do
{
    Console.Clear();
    Console.Write("Please enter the width: ");
    if (!double.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("___\n\nNot a number, please try again.");
        Task.Delay(2000).Wait();
    }
} while (width == 0);

double area = length * width;
double perimeter = 2 * (length + width);

Console.Clear();

Console.WriteLine("Results - \n\nLength: " + length + "\nWidth: " + width);
Console.WriteLine("\nArea: " + area);
Console.WriteLine("\nperimeter: " + perimeter);

if (area <= 250)
{
    Console.WriteLine("\nThis is a small room!");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("\nThis is a medium room!");
}
else if (area > 650)
{
    Console.WriteLine("\nThis is a large room!"); //testing this
}

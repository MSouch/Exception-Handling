using System;
    class Circle
{
    private double Radius;

    public void SetRadius(double radius)
    {
        if (radius > 0)
        {
            Radius = radius;
        }
        else
        {
            throw new InvalidRadiusException(radius);
        }
    }

    public override string ToString()
    {
        return $"Circle with radius: {Radius}";
    }
}
class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base("Invalid radius. Radius must be greater than zero.") { }

    public InvalidRadiusException(double invalidRadius) : base($"Invalid radius: {invalidRadius}. Radius must be greater than zero.") { }
}
class MainClass
{
    public static void Main(string[] args)
    {
        try
        {
            // Test with positive radius
            Circle circle1 = new Circle();
            circle1.SetRadius(5);
            Console.WriteLine(circle1.ToString());

            // Test with negative radius 
            Circle circle2 = new Circle();
            circle2.SetRadius(-2); // will throw InvalidRadiusException
            Console.WriteLine(circle2.ToString()); // This line won't be executed

        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            // Test with radius of zero
            Circle circle3 = new Circle();
            circle3.SetRadius(0); //  will throw InvalidRadiusException
            Console.WriteLine(circle3.ToString()); // This line won't be executed
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
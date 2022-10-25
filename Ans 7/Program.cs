class Program
{
    static void Main(string[] args)
    {
        // 7. Class Car.

        // a. Create a constructor for class "Car" that takes string of car brand and saves it to the field.
        Car car = new Car("BMW");
        
        // b. Create a function GetBrand that returns the brand of the car.
        Console.WriteLine(car.GetBrand() + "\n");
    }
}
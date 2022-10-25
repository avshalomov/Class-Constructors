class Car
{
    // a. Create a constructor for class "Car" that takes string of car brand and saves it to the field.
    private string brand;
    public Car(string brand)
    {
        this.brand = brand;
    }
    // b. Create a function GetBrand that returns the brand of the car.
    public string GetBrand()
    {
        return brand;
    }
}
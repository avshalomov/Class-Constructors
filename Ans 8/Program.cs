class Program
{
    static void Main(string[] args)
    {
        // 8. Create a program that creates 3 constructors for class "ConsolePlus".
        // a. The first constructor is default and prints "Default".
        ConsolePlus consolePlus1 = new ConsolePlus();
        // b. The second constructor takes string and prints it.
        ConsolePlus consolePlus2 = new ConsolePlus(3, 2);
        // c. The third constructor takes 2 numbers and prints the sum of them using the first and second constructor.
        ConsolePlus consolePlus3 = new ConsolePlus("Hello");
        // d. Create a constructor that gets 2 numbers, text and calls the third constructor, that calls the second constructor, that calls the first constructor.
        ConsolePlus consolePlus4 = new ConsolePlus(10, 5, "GoodBye");
    }
}
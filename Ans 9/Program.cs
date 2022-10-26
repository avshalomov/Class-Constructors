class Program
{
    static void Main(string[] args)
    {
        // 9. Create a class "Person" with _name field and a constructor that gets string name.


        // a. Create in Main string array with user's choice length.
        Console.WriteLine("How many people do you want to create?");
        int length = Convert.ToInt32(Console.ReadLine());
        string[] names = new string[length];


        // b. Run in loop with length of array and consturct Person objects with names from array.
        Person[] people = new Person[length];
        for (int i = 0; i < length; i++)
        {
            names[i] = RandomName();
            people[i] = new Person(names[i]);
        }


        // c. Run in loop and print all names from objects.
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Person #{i + 1} Name: {people[i]._name}");
        }
        Console.WriteLine();


        // d. Create a constructor that gets age and calls the constructor that gets name.
        // Done in Person.cs


        // e. Restart the array of string and create new array of numbers with user's choice length.
        names = new string[length];
        int[] ages = new int[length];


        // f. Run in loop and consturct Person objects with names and ages from arrays.
        people = new Person[length];
        for (int i = 0; i < length; i++)
        {
            // g. Every loop add ages and names to their arrays.
            names[i] = RandomName();
            ages[i] = RandomAge();
            people[i] = new Person(names[i], ages[i]);
        }


        // h. After loop is finished, print all the objects with loop: Name: "Moshe", Age: 42.
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Person #{i + 1} {people[i].GetNameAndAge()}");
        }
    }

    public static string RandomName()
    {
        Random r = new Random();
        int len = r.Next(5, 10);
        string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
        string Name = "";
        Name += consonants[r.Next(consonants.Length)].ToUpper();
        Name += vowels[r.Next(vowels.Length)];
        int b = 2;

        while (b < len)
        {
            Name += consonants[r.Next(consonants.Length)];
            b++;
            Name += vowels[r.Next(vowels.Length)];
            b++;
        }

        return Name;
    }

    public static int RandomAge()
    {
        Random r = new Random();
        int age = r.Next(1, 100);
        return age;
    }
}








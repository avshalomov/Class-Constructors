class Person
{
    public string _name;
    public int _age;
    public Person(string name)
    {
        _name = name;
    }
    public Person(string name, int age) : this(name)
    {
        _age = age;
    }

    public string GetNameAndAge()
    {
        return $"Name: \"{_name}\", Age: {_age}";
    }
}
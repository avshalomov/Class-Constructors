class ConsolePlus{
    public ConsolePlus(string text){
        Console.WriteLine(text+"\n");
    }
    public ConsolePlus() : this("Default"){}
    public ConsolePlus(int num1, int num2) : this((num1 + num2).ToString()){}
    public ConsolePlus(int num1, int num2, string text) : this(num1, num2){
        Console.WriteLine(text);
    }
}
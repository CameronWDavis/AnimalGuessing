namespace AnimalGuess 
{
public class Animal 
{
    public string Name { get; }
    public string Hint { get; }

    public Animal(string name, string hint)
    {
        Name = name;
        Hint = hint; 
    }
}
} 
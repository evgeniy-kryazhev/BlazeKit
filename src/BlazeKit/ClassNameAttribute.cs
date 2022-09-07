namespace BlazeKit;

public class ClassNameAttribute : Attribute
{
    public ClassNameAttribute(string? name)
    {
        Name = name;
    }

    public string? Name { get; set; }
}
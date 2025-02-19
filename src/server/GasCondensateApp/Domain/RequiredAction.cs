namespace Domain;

[AttributeUsage(AttributeTargets.Interface)]
public class RequiredAction : Attribute
{
    public RequiredAction(string name)
    {
        Name = name;
    }

    public string Name { get; }
}

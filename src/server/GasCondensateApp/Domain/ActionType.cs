
namespace Domain;

[AttributeUsage(AttributeTargets.All)]
public class ActionType : Attribute
{
    public ActionType(params ActionTypes[] types)
    {
        Types = types;
    }

    public ActionTypes[] Types;
}

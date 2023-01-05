namespace TauCode.Xml.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class PropertyElementAttribute : Attribute
{
    public PropertyElementAttribute(string? propertyName = null)
    {
        PropertyName = propertyName;
    }

    public string? PropertyName { get; }
}
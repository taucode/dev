namespace TauCode.Xml.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ElementArrayAttribute : Attribute
{
    public ElementArrayAttribute(string? propertyName = null)
    {
        PropertyName = propertyName;
    }

    public string? PropertyName { get; }
}

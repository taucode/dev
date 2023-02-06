namespace TauCode.Dev.Elements;

public class ProjectElement
{
    public class PropertyGroup
    {
        //[PropertyElement]
        public string? TargetFramework { get; set; }
    }

    #region Items

    public class Compile
    {
        public string? Remove { get; set; }
    }

    public class Content
    {
        public string? Remove { get; set; }
    }

    public class EmbeddedResource
    {
        public string? Remove { get; set; }
    }

    public class None
    {
        public string? Remove { get; set; }
    }

    public class PackageReference
    {
        public string? Include { get; set; }
        public string? Version { get; set; }
    }

    public class ProjectReference
    {
        public string? Include { get; set; }
    }

    #endregion

    public class ItemGroup
    {
        //[ElementArray("Compile")]
        public IList<Compile> CompileCollection { get; set; } = new List<Compile>();
    }
}
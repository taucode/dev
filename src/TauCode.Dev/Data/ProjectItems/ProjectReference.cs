namespace TauCode.Dev.Data.ProjectItems;

public class ProjectReference
{
    public ProjectReference()
    {
    }

    public ProjectReference(string localPath)
    {
        this.LocalPath = localPath;
    }

    public string LocalPath { get; set; }
}
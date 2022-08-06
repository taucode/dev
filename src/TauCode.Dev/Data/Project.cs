using TauCode.Dev.Data.ProjectItems;

namespace TauCode.Dev.Data;

public class Project
{
    public string Sdk { get; internal set; }
    public string Name { get; internal set; }
    public string TargetFramework { get; internal set; }
    public bool? IsPackable { get; internal set; }
    public string OutputType { get; internal set; }
    public string UserSecretsId { get; internal set; }
    public string DockerDefaultTargetOS { get; internal set; }
    public string DockerfileContext { get; internal set; }
    public IList<PackageReference> PackageReferences { get; } = new List<PackageReference>();
    public IList<ProjectReference> ProjectReferences { get; } = new List<ProjectReference>();
    public IList<LocalFileReference> ExcludedFiles { get; } = new List<LocalFileReference>();
    public IList<LocalFileReference> EmbeddedResources { get; } = new List<LocalFileReference>();
    public IList<LocalFileReference> Folders { get; } = new List<LocalFileReference>();
}
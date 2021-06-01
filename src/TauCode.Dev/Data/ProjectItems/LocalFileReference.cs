namespace TauCode.Dev.Data.ProjectItems
{
    public class LocalFileReference
    {
        public LocalFileReference()
        {   
        }

        public LocalFileReference(string localPath)
        {
            this.LocalPath = localPath;
        }

        public string LocalPath { get; set; }
    }
}
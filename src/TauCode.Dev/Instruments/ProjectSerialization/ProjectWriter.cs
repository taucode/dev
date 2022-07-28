using System;
using TauCode.Dev.Data;

namespace TauCode.Dev.Instruments.ProjectSerialization
{
    internal class ProjectWriter
    {
        internal ProjectWriter()
        {
        }

        // todo: get rid of 'Definition' substring
        internal void Write(Project project, string projectFilePath)
        {
            throw new NotImplementedException();

            // todo clean
            //var projectElement = new ProjectElement(NetCoreCsProjSchemaHolder.Schema);
            //projectElement.SetAttribute(nameof(Project.Sdk), project.Sdk);

            //var propertyGroup = (IComplexElement)projectElement.AddChildElement("PropertyGroup");
            //propertyGroup.AddTextNodeProperty(nameof(Project.TargetFramework), project.TargetFramework);
            //propertyGroup.AddTextNodeProperty(nameof(Project.UserSecretsId), project.UserSecretsId);
            //propertyGroup.AddTextNodeProperty(nameof(Project.DockerDefaultTargetOS), project.DockerDefaultTargetOS);
            //propertyGroup.AddTextNodeProperty(nameof(Project.DockerfileContext), project.DockerfileContext);

            //var doc = _serializer.Serialize(projectElement);

            //doc.Save(projectFilePath);
        }
    }
}

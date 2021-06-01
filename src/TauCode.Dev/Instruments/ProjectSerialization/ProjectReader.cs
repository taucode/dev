using System;
using TauCode.Dev.Data;

namespace TauCode.Dev.Instruments.ProjectSerialization
{
    internal class ProjectReader
    {
        internal ProjectReader()
        {
        }
        
        internal Project Read(string projectDefinitionFilePath)
        {
            throw new NotImplementedException();

            // todo clean
            //var doc = new XmlDocument();
            //doc.Load(projectDefinitionFilePath);

            //var root = _serializer.Deserialize(NetCoreCsProjSchemaHolder.Schema, doc);

            //var project = new Project();
            //project.Name = Path.GetFileNameWithoutExtension(projectDefinitionFilePath); // todo: get rid of 'Definition' substring

            //root.WritePropertiesTo(project);

            //var propertyGroups = root.GetChildren()
            //    .Where(x => x is PropertyGroupElement)
            //    .Cast<PropertyGroupElement>()
            //    .ToList();

            //foreach (var propertyGroup in propertyGroups)
            //{
            //    propertyGroup.WritePropertiesTo(project);
            //}

            //var itemGroups = root.GetChildren()
            //    .Where(x => x is ItemGroupElement)
            //    .Cast<ItemGroupElement>()
            //    .ToList();


            //foreach (var itemGroup in itemGroups)
            //{
            //    foreach (var child in itemGroup.GetChildren())
            //    {
            //        if (child is PackageReferenceElement packageReferenceElement)
            //        {
            //            project.PackageReferences.Add(new PackageReference(
            //                packageReferenceElement.Include,
            //                packageReferenceElement.Version));
            //        }
            //        else if (
            //            child is TextNodeElement textNodeElement1 &&
            //            textNodeElement1.GetName() == "ProjectReference")
            //        {
            //            project.ProjectReferences.Add(new ProjectReference(textNodeElement1.GetAttribute("Include")));
            //        }
            //        else if (
            //            child is TextNodeElement textNodeElement2 &&
            //            textNodeElement2.GetName() == "None")
            //        {
            //            project.ExcludedFiles.Add(new LocalFileReference(textNodeElement2.GetAttribute("Remove")));
            //        }
            //        else if (
            //            child is TextNodeElement textNodeElement3 &&
            //            textNodeElement3.GetName() == "EmbeddedResource")
            //        {
            //            project.EmbeddedResources.Add(new LocalFileReference(textNodeElement3.GetAttribute("Include")));
            //        }
            //        else if (
            //            child is TextNodeElement textNodeElement4 &&
            //            textNodeElement4.GetName() == "Folder")
            //        {
            //            project.Folders.Add(new LocalFileReference(textNodeElement4.GetAttribute("Include")));
            //        }
            //        else
            //        {
            //            throw new NotImplementedException();
            //        }
            //    }
            //}

            //return project;
        }
    }
}

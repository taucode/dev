//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Xml.Serialization;

//namespace TauCode.Rho.Xml.Caching
//{
//    internal class SchemataCache
//    {
//        internal static SchemataCache Instance { get; } = new SchemataCache();

//        private readonly Dictionary<Type, ElementTypeDescriptor> _elementSchemaDescriptors;

//        private SchemataCache()
//        {
//            _elementSchemaDescriptors = new Dictionary<Type, ElementTypeDescriptor>();
//        }

//        internal ElementTypeDescriptor GetOrCreateElementSchemaDescriptor(Type elementType)
//        {
//            var descriptor = _elementSchemaDescriptors.GetValueOrDefault(elementType);
//            if (descriptor == null)
//            {
//                descriptor = this.CreateElementSchemaDescriptor(elementType);
//            }

//            return descriptor;
//        }

//        private ElementTypeDescriptor CreateElementSchemaDescriptor(Type elementType)
//        {
//            var elementSchemaDescriptor = new ElementTypeDescriptor(elementType);
//            _elementSchemaDescriptors.Add(elementType, elementSchemaDescriptor);

//            var props = elementType.GetProperties();

//            foreach (var prop in props)
//            {
//                if (prop.HasAttribute<XmlIgnoreAttribute>())
//                {
//                    continue;
//                }

//                if (IsElementProperty(prop))
//                {
//                    // Element
//                    string childElementName;

//                    var elementAttribute = prop.GetCustomAttribute<RhoElementAttribute>();

//                    if (elementAttribute == null)
//                    {
//                        childElementName = prop.Name;
//                    }
//                    else
//                    {
//                        throw new NotImplementedException();
//                    }

//                    var childElementSchemaDescriptor = this.GetOrCreateElementSchemaDescriptor(prop.PropertyType);

//                    elementSchemaDescriptor.AddChildElement(childElementName, childElementSchemaDescriptor);
//                }
//                else if (IsElementListProperty(prop))
//                {
//                    // Element List
//                    throw new NotImplementedException();
//                }
//                else if (prop.HasAttribute<RhoTextNodeElementValueAttribute>())
//                {
//                    throw new NotImplementedException();
//                }
//                else if (prop.HasAttribute<RhoAttributeValueAttribute>())
//                {
//                    throw new NotImplementedException();
//                }
//                else if (prop.PropertyType.IsSimpleType())
//                {
//                    elementSchemaDescriptor.AddAttribute(prop.Name, prop, prop.PropertyType.IsValueType);
//                }
//                else if (prop.PropertyType.IsNullableSimpleType())
//                {
//                    elementSchemaDescriptor.AddAttribute(prop.Name, prop, prop.PropertyType.IsValueType);
//                }
//                else
//                {
//                    throw new NotImplementedException();
//                }
//            }

//            throw new NotImplementedException();
//        }

//        private static bool IsElementProperty(PropertyInfo prop)
//        {
//            return typeof(IRhoElement).IsAssignableFrom(prop.PropertyType);
//        }

//        private static bool IsElementListProperty(PropertyInfo prop)
//        {
//            var type = prop.PropertyType;
//            if (type.IsGenericType)
//            {
//                var generic = type.GetGenericTypeDefinition();
//                if (generic == typeof(IList<>))
//                {
//                    throw new NotImplementedException();
//                }
//            }

//            return false;
//        }
//    }
//}


// todo clean
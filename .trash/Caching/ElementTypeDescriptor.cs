//using System;
//using System.Collections.Generic;
//using System.Reflection;

//namespace TauCode.Rho.Xml.Caching
//{
//    internal class ElementTypeDescriptor
//    {
//        private readonly Dictionary<string, AttributeSchemaDescriptor> _attributes;
//        private readonly Dictionary<string, ElementTypeDescriptor> _childElementSchemaDescriptors;

//        internal ElementTypeDescriptor(Type elementType)
//        {
//            this.ElementType = elementType;
//            _attributes = new Dictionary<string, AttributeSchemaDescriptor>();
//            _childElementSchemaDescriptors = new Dictionary<string, ElementTypeDescriptor>();
//        }

//        internal Type ElementType { get; }

//        internal void AddAttribute(string attributeName, PropertyInfo boundProperty, bool isMandatory)
//        {
//            // todo: checks?

//            if (_attributes.ContainsKey(attributeName))
//            {
//                throw new NotImplementedException();
//            }

//            var attributeSchemaDescriptor = new AttributeSchemaDescriptor(attributeName, boundProperty, isMandatory);
//            _attributes.Add(attributeSchemaDescriptor.AttributeName, attributeSchemaDescriptor);
//        }

//        internal void AddChildElement(string childElementName, ElementTypeDescriptor childElementSchemaDescriptor)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

// todo clean
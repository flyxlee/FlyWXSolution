using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WXService.Helper
{
    public class EntityXmlHelper
    {
        public static string ConvertEntityToXml<T>(T entity)where T:class
        {
            string result = string.Empty;
            using (MemoryStream output = new MemoryStream())
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                //Add an empty namespace and empty value
                ns.Add("", "");
                XmlSerializer serializer = new XmlSerializer(entity.GetType());
                serializer.Serialize(output, entity, ns);
                //byte[] bytes = output.ToArray();
                //bytes = bytes.Skip(21).ToArray();
                //result = Encoding.UTF8.GetString(bytes);
                result = Encoding.UTF8.GetString(output.ToArray());
            }
            return result;
        }

        public static void FillEntityWithXml<T>(T entity, XDocument doc) where T : class, new()
        {
            entity = entity ?? new T();
            var root = doc.Root;

            var props = entity.GetType().GetProperties();
            foreach (var prop in props)
            {
                var propName = prop.Name;
                if(root.Element(propName)!= null){
                    switch (prop.PropertyType.Name)
                    {
                        case "String":
                            prop.SetValue(entity, root.Element(propName).Value, null);
                            break;
                        default:
                            prop.SetValue(entity, root.Element(propName).Value, null);
                            break;
                    }
                    
                }
            }

        }

    }
}

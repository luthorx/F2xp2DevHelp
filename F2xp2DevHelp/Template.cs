using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace F2xp2DevHelp
{
    abstract class Template
    {
        public const string _PROPERTY_NAME = "[<Property>]";
        public const string _PROPERTY_TYPE = "[<PropertyType>]";
        public const string _GET = "[<GET>]";
        public const string _SET = "[<SET>]";

        public Template(string Name)
        {
            TemplateChunk = CreateTemplate();
            GET = CreateGet();
            SET = CreateSet();
        }

        public override string ToString()
        {
            return Name;
        }

        public string Name { get; set; }
        public string TemplateChunk { get; set; }
        public string GET { get; set; }
        public string SET { get; set; }

        protected virtual string CreateGet()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("\t\tget");
            str.AppendLine("\t\t\t{");
            str.AppendLine(string.Format("\t\t\t\treturn _{0};", Template._PROPERTY_NAME));
            str.AppendLine("\t\t\t}");

            return str.ToString();
        }

        protected virtual string CreateSet()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("\t\tset");
            str.AppendLine("\t\t\t{");
            str.AppendLine(string.Format("\t\t\t\t_{0} = value;", Template._PROPERTY_NAME));
            str.AppendLine("\t\t\t}");

            return str.ToString();
        }

        protected virtual string CreateTemplate()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(string.Format("\t\tprivate {0} _{1};", Template._PROPERTY_TYPE, Template._PROPERTY_NAME));
            str.AppendLine(string.Format("\t\tpublic {0} {1}", Template._PROPERTY_TYPE, Template._PROPERTY_NAME));
            str.AppendLine("\t\t{");
            str.AppendLine(Template._GET);
            str.AppendLine(Template._SET);
            str.AppendLine("\t\t}");
            return str.ToString();
        }

        public string GetChunk(PropertyInfo property, bool forceSet = false)
        {

            return GetChunk(property, TemplateChunk, GET, SET);

        }

        public string GetChunk(PropertyInfo property,
                               string CustomTemplate,
                               string CustomGet,
                               string CustomSet,
                               bool forceSet = false)
        {

            //replace get 
            var myGet = CustomGet.Replace(_PROPERTY_NAME, property.Name);
            var mySet = CustomSet.Replace(_PROPERTY_NAME, property.Name);
            var tChunk = CustomTemplate.Replace(_PROPERTY_NAME, property.Name);

            tChunk = tChunk.Replace(_GET, myGet);
            if (property.CanWrite || forceSet)
                tChunk = tChunk.Replace(_SET, mySet);
            else
                tChunk = tChunk.Replace(_SET, string.Empty);

            var propertyType = property.PropertyType;
            var pType = property.PropertyType.Name;
            //if (propertyType.IsPrimitive)
            //    pType = propertyType.;

            tChunk = tChunk.Replace(_PROPERTY_TYPE, pType);

            
            return tChunk;

        }
    }
}

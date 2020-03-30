using System;
using System.Linq;
using System.Text;

namespace F2xp2DevHelp
{
    class TemplateDevExpress : Template
    {
        public TemplateDevExpress(string name) : base(name)
        {
            Name = name;
        }


        protected override string CreateSet()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("set");
            str.AppendLine("\t\t\t{");
            str.AppendLine(string.Format("\t\t\t\tSetPropertyValue(nameof({0}), ref _{0}, value);", Template._PROPERTY_NAME));
            str.AppendLine("\t\t\t}");

            return str.ToString();
        }

    }
}

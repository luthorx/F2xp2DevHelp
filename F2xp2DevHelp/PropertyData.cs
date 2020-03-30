using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace F2xp2DevHelp
{
    class PropertyData
    {
        public PropertyInfo Property { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Property.ToString());
            builder.Append(" GET");
            if (Property.CanWrite)
                builder.Append(" SET");

            return builder.ToString();

        }

        public PropertyData(PropertyInfo property)
        {
            Property = property;
        }

    }
}

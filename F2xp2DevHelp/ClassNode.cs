using System;
using System.Linq;
using System.Windows.Forms;

namespace F2xp2DevHelp
{
    class ClassNode : TreeNode
    {


        public Type ClassType { get; private set; }

        public ClassNode(Type type)
        {
            ClassType = type;
            Text = type.Name;
        }
    }
}

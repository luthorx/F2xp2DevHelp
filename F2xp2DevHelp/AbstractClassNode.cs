using System;
using System.Linq;
using System.Windows.Forms;

namespace F2xp2DevHelp
{
    class AbstractClassNode : TreeNode
    {


        public Type ClassType { get; private set; }

        public AbstractClassNode(Type type)
        {
            ClassType = type;
            Text = type.Name;
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace F2xp2DevHelp
{
    class InterfaceNode : TreeNode
    {


        public Type InterfaceType { get; private set; }

        public InterfaceNode(Type type)
        {
            InterfaceType = type;
            Text = type.Name;
        }
    }
}

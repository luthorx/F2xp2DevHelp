using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace F2xp2DevHelp
{
    class AssemblyNode : TreeNode
    {
        Assembly _assembly;
        string _filename;
        TreeNode Interfaces;
        TreeNode Classes;
        TreeNode AbstractClasses;

        public AssemblyNode(Assembly assembly, string filename)
        {
            _assembly = assembly;
            _filename = filename;
            this.Name = assembly.FullName;
            this.Text = Path.GetFileName(filename);
            Interfaces = new TreeNode("Interfaces");
            Classes = new TreeNode("Classes");
            AbstractClasses = new TreeNode("Abstract Classes");
            Nodes.Add(Interfaces);
            Nodes.Add(Classes);
            Nodes.Add(AbstractClasses);
            GetInterfaces();
            GetClasses();
            GetAbastractClasses();
        }

        void GetAbastractClasses()
        {
            var types = _assembly.GetExportedTypes();
            foreach (var type in types)
            {
                if (type.IsClass && type.IsAbstract && !type.IsSealed)
                {

                    var inode = new AbstractClassNode(type);
                    AbstractClasses.Nodes.Add(inode);
                }
            }
        }

        void GetClasses()
        {
            var types = _assembly.GetExportedTypes();
            foreach (var type in types)
            {
                if (type.IsClass && !type.IsAbstract && !type.IsSealed)
                {
                    var inode = new ClassNode(type);
                    Classes.Nodes.Add(inode);
                }
            }
        }

        void GetInterfaces()
        {
            var types = _assembly.GetExportedTypes();
            foreach (var type in types)
            {
                if (type.IsInterface)
                {
                    var inode = new InterfaceNode(type);
                    Interfaces.Nodes.Add(inode);
                }
            }
        }

    }
}

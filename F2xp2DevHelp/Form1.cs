using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F2xp2DevHelp
{
    public partial class Form1 : Form
    {
        Dictionary<string, AssemblyNode> nodes = new Dictionary<string, AssemblyNode>();
        Type currenType;
        public Form1()
        {
            InitializeComponent();
            TreeAssemblies.AfterSelect += TreeAssemblies_AfterSelect;
            cmbTemplates.Items.Add(new TemplateDefault("Default"));
            cmbTemplates.Items.Add(new TemplateDevExpress("DevExpress"));
            cmbTemplates.SelectedIndexChanged += CmbTemplates_SelectedIndexChanged;
            cmbTemplates.SelectedIndex = 0;
        }

        private void CmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = cmbTemplates.SelectedItem as Template;
            txtGet.Text = current.GET;
            txtSet.Text = current.SET;
            txtTemplate.Text = current.TemplateChunk;

        }

        private void TreeAssemblies_AfterSelect(object sender, TreeViewEventArgs e)
        {
            button1.Enabled = e.Node is InterfaceNode;
            chkData.Visible = e.Node is InterfaceNode;
            chkData.Items.Clear();
            if (e.Node is InterfaceNode)
            {
                currenType = ((InterfaceNode)e.Node).InterfaceType;
                var properties = currenType.GetProperties();
                
                foreach (var property in properties)
                {
                    
                    chkData.Items.Add(new PropertyData(property), true);
                }
            }  else
            {
                currenType = null;
            }

        }

        private void AddDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Title = "Select a .net file",
                Filter = "DLL Files (*.dll)|*.dll|All Files (*.*)|*.*",
                 DefaultExt = "dll"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var assembly = Assembly.LoadFrom(dlg.FileName);
                    var node = new AssemblyNode(assembly, dlg.FileName);
                    if (!nodes.ContainsKey(dlg.FileName))
                    {
                        nodes.Add(dlg.FileName, node);
                        TreeAssemblies.Nodes.Add(node);
                    } else
                    {
                        //    
                    }
                                                                  
                    
                }
                catch
                {
                    MessageBox.Show("I cannot add this assembly");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Title = "Select a .cs file",
                Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*",
                DefaultExt = "cs"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                var code = GenerateCode(currenType.Name, cmbTemplates.SelectedItem as Template);
                var name = string.Format("{0}.{1}", currenType.Namespace, currenType.Name);

                var content = File.ReadAllText(dlg.FileName);

                content = content.Replace("//[<TYPE>]", name);
                content = content.Replace("//[<CODE>]", code);

                File.WriteAllText(dlg.FileName, content);
            }

        }

        private string GenerateCode(string Name, Template template)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("#region Interface {0}", Name);
            foreach (var item in chkData.Items)
            {
                var data = item as PropertyData;

                
                sb.AppendLine();
                sb.AppendLine(template.GetChunk(data.Property,
                                                    txtTemplate.Text,
                                                    txtGet.Text,
                                                    txtSet.Text, chkForceSet.Checked));
                sb.AppendLine();
               
            }
            sb.AppendLine("#endregion");

            return sb.ToString() ;
        }
    }
}
 
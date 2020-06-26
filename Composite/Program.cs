using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = CreateNode();
            TranverseTree(node);

            Console.ReadKey();
        }
        static void TranverseTree(CustomNode node)
        {
            if(node is MidNode)
            {
                var mid = node as MidNode;
                Console.WriteLine($"中间节点：{ mid.Name}");
                if(mid.Children!=null)
                {
                    foreach (var sub in mid.Children)
                    {
                        TranverseTree(sub);
                    }
                }
            }
            else if(node  is LeafNode)
            {
                var leaf = node as LeafNode;
                Console.WriteLine($"叶节点：{leaf.Name}、{leaf.Value}");
            }
        }
        static CustomNode CreateNode()
        {
            MidNode root = new MidNode("根节点");
            MidNode par1 = new MidNode("父节点1");
            MidNode par2 = new MidNode("父节点2");
            MidNode par3 = new MidNode("父节点3");

            root.AddChild(new LeafNode("数值0", "叶节点0"));
            root.AddChild(par1);
            root.AddChild(par2);
            root.AddChild(par3);

            par1.AddChild(new LeafNode("数值1", "叶节点1"));
            par1.AddChild(new LeafNode("数值2", "叶节点2"));
            par1.AddChild(new LeafNode("数值3", "叶节点3"));

            par2.AddChild(new LeafNode("数值4", "叶节点4"));
            par2.AddChild(new LeafNode("数值5", "叶节点5"));
            par2.AddChild(new LeafNode("数值6", "叶节点6"));

            par3.AddChild(new LeafNode("数值7", "叶节点7"));
            par3.AddChild(new LeafNode("数值8", "叶节点8"));
            par3.AddChild(new LeafNode("数值9", "叶节点9"));

            MidNode par4 = new MidNode("父节点4");
            par3.AddChild(par4);
            par4.AddChild(new LeafNode("数值10", "叶节点10"));
            par4.AddChild(new LeafNode("数值11", "叶节点11"));

            return root;
        }
    }
}

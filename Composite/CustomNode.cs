using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 安全组合模式
    /// </summary>
    abstract class CustomNode
    {
        public abstract string Name { get; set; }
    }
    class MidNode : CustomNode
    {
        public override string Name { get; set; }
        private List<CustomNode> children;
        public IEnumerable<CustomNode> Children
        {
            get { return children; }
        }

        public void AddChild(CustomNode node)
        {
            if (children == null)
                children = new List<CustomNode>();
            children.Add(node);
        }
        public CustomNode GetChild(int index)
        {
            if (children == null || children.Count <= index || index < 0)
                return null;
            return children[index];
        }
        public MidNode(string name)
        {
            Name = name;
        }
    }
    class LeafNode : CustomNode
    {
        public override string Name { get; set; }
        public string Value { get; private set; }
        public LeafNode(string value,string name)
        {
            Value = value;
            Name = name;
        }
    }
}

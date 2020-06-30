using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class NodeMgr
    {
        private Node node;
        private static NodeMgr inst;
        public static NodeMgr Inst
        {
            get
            {
                if (inst == null)
                    inst = new NodeMgr();
                return inst;
            }
        }
        private NodeMgr() { }

        public bool AnalyzeCommand(string cmd)
        {
            if (string.IsNullOrEmpty(cmd))
                return false;

            var cmdlist = cmd.Split(' ');

            Stack<Node> stack = new Stack<Node>();
            for(int index=0;index<cmdlist.Count();index++)
            {
                var str = cmdlist[index];
                if(str.Equals("and"))
                {
                    var left = stack.Pop();
                    DirectionNode dir = new DirectionNode(cmdlist[++index]);
                    WayNode way = new WayNode(cmdlist[++index]);
                    DistanceNode dis=new DistanceNode(cmdlist[++index]);
                    var right = new CommandNode(dir, way, dis);
                    AndNode andNode = new AndNode(left, right);
                    stack.Push(andNode);
                }
                else
                {
                    DirectionNode dir = new DirectionNode(str);
                    WayNode way = new WayNode(cmdlist[++index]);
                    DistanceNode dis = new DistanceNode(cmdlist[++index]);
                    CommandNode cmdnode = new CommandNode(dir, way, dis);
                    stack.Push(cmdnode);
                }
            }
            node = stack.Pop();
            return true;
        }
        public string Translate()
        {
            return node.Translate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    abstract class Node
    {
        public abstract string Translate();
    }
    class DirectionNode : Node
    {
        private string dirrction;
        public DirectionNode(string dir)
        {
            dirrction = dir;
        }
        public override string Translate()
        {
            switch (dirrction)
            {
                case "back":
                    return "向后";
                case "front":
                    return "向前";
                case "left":
                    return "向左";
                case "right":
                    return "向右";
                default:
                    return "无效";
            }
        }
    }
    class DistanceNode : Node
    {
        private string distance;
        public DistanceNode(string dist)
        {
            distance = dist;
        }
        public override string Translate()
        {
            return $"{distance}米";
        }
    }
    class WayNode : Node
    {
        private string way;
        public WayNode(string way)
        {
            this.way = way;
        }
        public override string Translate()
        {
            switch(way)
            {
                case "walk":
                    return "行走";
                case "run":
                    return "跑步";
                default:
                    return "无效";
            }
        }
    }
    class AndNode : Node
    {
        Node left;
        Node right;
        public AndNode(Node left,Node right)
        {
            this.left = left;
            this.right = right;
        }
        public override string Translate()
        {
            return left.Translate() + "然后" + right.Translate();
        }
    }
    class CommandNode : Node
    {
        Node dir;
        Node way;
        Node dis;
        public CommandNode(Node dir,Node way,Node dis)
        {
            this.dir = dir;
            this.way = way;
            this.dis = dis;
        }
        public override string Translate()
        {
            return dir.Translate() + way.Translate() + dis.Translate();
        }
    }
}

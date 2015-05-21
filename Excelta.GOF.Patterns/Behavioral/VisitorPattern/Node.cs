using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.VisitorPattern
{
    public abstract class Node
    {
        protected Node _rightNode = null;
        protected Node _leftNode = null;
        protected object _nodeValue = null;
        public abstract Node getLeftNode();
        public abstract void setLeftNode(Node n);
        public abstract Node getRightNode();
        public abstract void SetRightNode(Node n);
        public abstract object GetNodeValue();
        public abstract void SetNodeValue(object nodeValue);

        public abstract void Accept(NodeVisitor visitor);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.VisitorPattern
{
    public class OperationNode:Node
    {

        private static char[] _operations = new char[] { '*', '/', '+', '-', '%' };

        /// <summary>
        /// To implement this function will build a node tree corresponding to the operations
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static OperationNode ParseString(string str)
        {
            
            String[] leftAndRightNodes = str.Split(_operations, 2);

            if (leftAndRightNodes.Length == 1)
            {
                // It meeans there are no subNodes and the value is just the string itself
                OperationNode node = new OperationNode();
                node.setLeftNode(null);
                node.SetRightNode(null);
                node.SetNodeValue(leftAndRightNodes[0]);
                return node;

            }
            else
            {
                // That means we have two subNodes to explore
                int leftLength = leftAndRightNodes[0].Length;
                String strOp = str.Substring(leftLength, 1);
                OperationNode node = new OperationNode();
                node.SetNodeValue(strOp);
                node.setLeftNode(OperationNode.ParseString( leftAndRightNodes[0] ));
                node.SetRightNode(OperationNode.ParseString(leftAndRightNodes[1]));
                return node;

            }

            

            
        }

        public override Node getLeftNode()
        {
            return _leftNode;
        }

        public override void setLeftNode(Node n)
        {
            _leftNode = n;
        }

        public override Node getRightNode()
        {
            return _rightNode;
        }

        public override void SetRightNode(Node n)
        {
            _rightNode = n;
        }

        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitOperation(this);



        }

        public override object GetNodeValue()
        {
            return _nodeValue;
        }

        public override void SetNodeValue(object nodeValue)
        {
            _nodeValue = nodeValue;
        }
    }
}

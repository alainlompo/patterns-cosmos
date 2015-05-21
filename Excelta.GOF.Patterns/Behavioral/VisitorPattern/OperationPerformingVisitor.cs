using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.VisitorPattern
{
    public class OperationPerformingVisitor:NodeVisitor
    {
        public delegate int ArithmeticDelegate(int x, int y);
        private ArithmeticDelegate arithmeticFunction;
        public int Mulitplication(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x / y;

        }

        public int Modulo(int x, int y)
        {
            return x % y;
        }
        public int Addition(int x, int y)
        {
            return x + y;

        }
        public int Soustraction(int x, int y)
        {
            return x- y;

        }
        private int _evaluationResult = 0;
        public int GetEvaluationResult()
        {
            return _evaluationResult;
        }

               
        public int Evaluate(OperationNode node)
        {
            OperationNode leftNode = (OperationNode)node.getLeftNode();
            OperationNode rightNode = (OperationNode)node.getRightNode();
            object nodeValue = node.GetNodeValue();
            string nodeValueStr= "";
            if (nodeValue != null)
            {
                nodeValueStr = nodeValue.ToString().Trim();
                if (nodeValueStr.Equals("+"))
                    arithmeticFunction = new ArithmeticDelegate(Addition);
                else if (nodeValueStr.Equals("-"))
                    arithmeticFunction = new ArithmeticDelegate(Soustraction);
                else if (nodeValueStr.Equals("*"))
                    arithmeticFunction = new ArithmeticDelegate(Mulitplication);
                else if (nodeValueStr.Equals("/"))
                    arithmeticFunction = new ArithmeticDelegate(Division);
                else if (nodeValueStr.Equals("%"))
                    arithmeticFunction = new ArithmeticDelegate(Modulo);
            }
            if (leftNode != null && rightNode != null)
            {
                return arithmeticFunction(Evaluate(leftNode), Evaluate(rightNode));




            }
            else if (leftNode == null && rightNode == null)
            {
                if (nodeValue != null)
                {
                    int nodeValueInt = Int32.Parse(nodeValueStr);
                    return nodeValueInt;
                }
                else return -1;

            }
            else return -1;





        }

        public override void VisitOperation(OperationNode node)
        {
            _evaluationResult = Evaluate(node);

        }

        public override void VisitReference(ReferenceNode node)
        {
           
        }

        public override void VisitAssignment(AssignementNode node)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.VisitorPattern.TestOperationEvaluation
{
    public class OperationEvaluationMock
    {
        OperationNode Node_1 = null;
        public OperationNode GetDemoNode()
        {
            return Node_1;
        }
        public void BuildDemoNodes()
        {
            Node_1 = new OperationNode();
            Node_1.SetNodeValue("*");

               OperationNode Node_1_L = new OperationNode();
                  OperationNode Node_1_L_L = null;
                  OperationNode Node_1_L_R = null;
               Node_1_L.setLeftNode(Node_1_L_L);
               Node_1_L.SetRightNode(Node_1_L_R);
               Node_1_L.SetNodeValue("5");

               OperationNode Node_1_R = new OperationNode();
                  OperationNode Node_1_R_L = new OperationNode();
                     OperationNode Node_1_R_L_L = null;
                     OperationNode Node_1_R_L_R = null;
                  Node_1_R_L.setLeftNode(Node_1_R_L_L);
                  Node_1_R_L.SetRightNode(Node_1_R_L_R);
                  Node_1_R_L.SetNodeValue("3");

                  OperationNode Node_1_R_R = new OperationNode();
                     OperationNode Node_1_R_R_L = new OperationNode();
                        OperationNode Node_1_R_R_L_L = null;
                        OperationNode Node_1_R_R_L_R = null;
                     Node_1_R_R_L.setLeftNode(Node_1_R_R_L_L);
                     Node_1_R_R_L.SetRightNode(Node_1_R_R_L_R);
                     Node_1_R_R_L.SetNodeValue("2");
                     OperationNode Node_1_R_R_R = new OperationNode();
                        OperationNode Node_1_R_R_R_L = null;
                        OperationNode Node_1_R_R_R_R = null;
                     Node_1_R_R_R.setLeftNode(Node_1_R_R_R_L);
                     Node_1_R_R_R.SetRightNode(Node_1_R_R_R_R);
                     Node_1_R_R_R.SetNodeValue("3");


                  Node_1_R_R.setLeftNode(Node_1_R_R_L);
                  Node_1_R_R.SetRightNode(Node_1_R_R_R);
                  Node_1_R_R.SetNodeValue("%");

               Node_1_R.setLeftNode(Node_1_R_L);
               Node_1_R.SetRightNode(Node_1_R_R);
               Node_1_R.SetNodeValue("/");

            Node_1.setLeftNode(Node_1_L);
            Node_1.SetRightNode(Node_1_R);

               

        }

        public void BuildDemoNodes2()
        {
            Node_1 = new OperationNode();
            Node_1.SetNodeValue("*");

            OperationNode Node_1_L = new OperationNode();
            OperationNode Node_1_L_L = null;
            OperationNode Node_1_L_R = null;
            Node_1_L.setLeftNode(Node_1_L_L);
            Node_1_L.SetRightNode(Node_1_L_R);
            Node_1_L.SetNodeValue("5");

            OperationNode Node_1_R = new OperationNode();
            OperationNode Node_1_R_L = new OperationNode();
            OperationNode Node_1_R_L_L = null;
            OperationNode Node_1_R_L_R = null;
            Node_1_R_L.setLeftNode(Node_1_R_L_L);
            Node_1_R_L.SetRightNode(Node_1_R_L_R);
            Node_1_R_L.SetNodeValue("3");

            OperationNode Node_1_R_R = new OperationNode();
            OperationNode Node_1_R_R_L = new OperationNode();
            OperationNode Node_1_R_R_L_L = null;
            OperationNode Node_1_R_R_L_R = null;
            Node_1_R_R_L.setLeftNode(Node_1_R_R_L_L);
            Node_1_R_R_L.SetRightNode(Node_1_R_R_L_R);
            Node_1_R_R_L.SetNodeValue("2");
            OperationNode Node_1_R_R_R = new OperationNode();
            OperationNode Node_1_R_R_R_L = null;
            OperationNode Node_1_R_R_R_R = null;
            Node_1_R_R_R.setLeftNode(Node_1_R_R_R_L);
            Node_1_R_R_R.SetRightNode(Node_1_R_R_R_R);
            Node_1_R_R_R.SetNodeValue("3");


            Node_1_R_R.setLeftNode(Node_1_R_R_L);
            Node_1_R_R.SetRightNode(Node_1_R_R_R);
            Node_1_R_R.SetNodeValue("*");

            Node_1_R.setLeftNode(Node_1_R_L);
            Node_1_R.SetRightNode(Node_1_R_R);
            Node_1_R.SetNodeValue("*");

            Node_1.setLeftNode(Node_1_L);
            Node_1.SetRightNode(Node_1_R);



        }

        public bool Assert(int expectedValue)
        {

            OperationPerformingVisitor visitor = new OperationPerformingVisitor();
            int result = visitor.Evaluate(Node_1);
            return (result == expectedValue);

        }
        public OperationEvaluationMock()
        {
            BuildDemoNodes2();

        }
    }
}

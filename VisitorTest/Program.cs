using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excelta.GOF.Patterns.Behavioral.VisitorPattern;

namespace VisitorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Excelta.GOF.Patterns.Behavioral.VisitorPattern.TestOperationEvaluation.OperationEvaluationMock
                mock = new Excelta.GOF.Patterns.Behavioral.VisitorPattern.TestOperationEvaluation.OperationEvaluationMock();
            string res = (mock.Assert(5)) ? "5" : "erreur";
            Console.WriteLine("Le resultat de l'operation 5*3/2%3 est " + res);
            Console.ReadKey();

            Console.WriteLine("Second procédé...");
            Excelta.GOF.Patterns.Behavioral.VisitorPattern.OperationNode n
                = mock.GetDemoNode();
            Excelta.GOF.Patterns.Behavioral.VisitorPattern.OperationPerformingVisitor
                visitor = new Excelta.GOF.Patterns.Behavioral.VisitorPattern.OperationPerformingVisitor();

            n.Accept(visitor);
            Console.WriteLine("Resultat : " + visitor.GetEvaluationResult().ToString());
            Console.ReadKey();

            Console.WriteLine("Troisieme procédé...");
            string chaine = "4-8*3+10/2*4";
            Excelta.GOF.Patterns.Behavioral.VisitorPattern.OperationNode
                node = Excelta.GOF.Patterns.Behavioral.VisitorPattern.OperationNode.ParseString(chaine);
            OperationPerformingVisitor visitor2 = new OperationPerformingVisitor();
            node.Accept(visitor2);
            Console.WriteLine("Le resultat de " + chaine + " est " + visitor2.GetEvaluationResult().ToString());
            Console.ReadKey();

            Console.WriteLine("Saisissez votre propre expression numérique (+,-,/,*, %) autorisés");
            String expr = Console.ReadLine();

            Excelta.GOF.Patterns.Behavioral.VisitorPattern.OperationNode
              node2 = Excelta.GOF.Patterns.Behavioral.VisitorPattern.OperationNode.ParseString(expr);
            OperationPerformingVisitor visitor3 = new OperationPerformingVisitor();
            node2.Accept(visitor3);
            Console.WriteLine("Le resultat de " + expr + " est " + visitor3.GetEvaluationResult().ToString());
            Console.ReadKey();






        }
    }
}

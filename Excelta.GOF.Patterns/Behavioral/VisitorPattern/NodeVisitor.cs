using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Behavioral.VisitorPattern
{
    public abstract class NodeVisitor
    {
        public abstract void VisitOperation(OperationNode node);
        public abstract void VisitReference(ReferenceNode node);
        public abstract void VisitAssignment(AssignementNode node);

    }
}

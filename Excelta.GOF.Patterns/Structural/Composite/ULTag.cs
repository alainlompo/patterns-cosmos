using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Composite
{
    public class ULTag:Tag
    { 
        public ULTag()
            : base("UL")
        {
        }
        public override void Add(Tag t)
        {
            
        } 

    }
}

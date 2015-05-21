using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Composite
{
    public struct KeyValuePair
    {
        public string Key;
        public Object Value;

        public KeyValuePair(string k, object v)
        {
            Key = k;
            Value = v;

        }
    }
}
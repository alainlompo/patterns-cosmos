using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.SingletonPattern
{
   public class Account
    {
        public int Balance { get; private set; }
        public string  Owner { get; private set; }

        public Account(int bal, string own)
        {
            Balance = bal;
            Owner = own;


        }

    }
}

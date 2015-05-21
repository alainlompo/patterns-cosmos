using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.SingletonPattern
{
    public struct NumberedAccount
    {
        public int accountNumber;
        public Account account;
        public NumberedAccount(int acN, Account acc)
        {
            accountNumber = acN;
            account = acc;
            
        }
    }
}

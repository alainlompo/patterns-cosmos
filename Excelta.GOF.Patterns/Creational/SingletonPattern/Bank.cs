using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Creational.SingletonPattern
{
    /// <summary>
    /// Bank is a Singleton, you can have only one Bank instance at any time
    /// </summary>
    public class Bank
    {
        private static int _currentNumber = 0;
        private static Bank _uniqueInstance;
        public static Bank Instance()
        {
            if (_uniqueInstance == null)
                _uniqueInstance = new Bank();
            return _uniqueInstance;
        }

        private Bank()
        {

        }
        public NumberedAccount GetNewAccount(int bal, string owner)
        {
            return new NumberedAccount(++_currentNumber, new Account(bal, owner));
            
        }
    }
}

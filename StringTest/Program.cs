using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper = "5*3+8*11-10";
            string[] res = oper.Split(new char[] { '*', '/', '+', '-', '%' }, 2);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);


            String oper2 = "55";
            string[] res2 = oper2.Split(new char[] { '*', '/', '+', '-', '%' }, 2);
            Console.WriteLine(res2.Length);

            Console.ReadKey();
        }
    }
}

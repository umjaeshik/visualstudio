using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
    class myLib
    {
        public string GetToken(string str, int n, char ch)  //str: " 1 2 3 " "1, 2, 3", (n)번째, ',' ' '
        {
            return str.Split(ch)[n];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

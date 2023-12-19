using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                object obj;
                int i = 10, j = 20;
                double d = 1.5, e = 3.1;
            obj = i;
                WriteLine("Hello world({0},{1}) \n Main function({1},{0})", obj, j);
            obj = d;
            while (true)
            {
                try
                {
                    
                   
                    string str = ReadLine();
                    i = int.Parse(str.Split(' ')[0]);
                    j = int.Parse(str.Split(' ')[1]);

                    WriteLine($"HELLO WORLD ({i}, {j})\nMain function({obj}, {e})");
                }
                catch (Exception e1) { WriteLine(e1.Message);
                    WriteLine("좋은 말로 할때 입력을 잘 하시오!!");
                }
            }
        }
    }
}

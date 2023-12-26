using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02_List
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test02 proc = new Test02();
            proc.MainFunc();
        }
    }
    class Test02
    {
        void Func_ListTest()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2.54);
            list.Add('a');
            list.Add("안녕하세용");
            for(int i=0; i<list.Count; i++) Console.WriteLine(list[i]);
            list.Remove('a');
            list.Add(5);
            list.Insert(2,'b');
            for (int i = 0; i < list.Count; i++) Console.WriteLine(list[i]);

            ArrayList list1 = new ArrayList();
            list1 = list;
            for (int i = 0; i < list1.Count; i++) Console.WriteLine(list1[i]);



        }

        void Func_DictionaryTest()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "a");
            dic.Add("2", "b");
            dic.Add("3", "c");
            dic.Add("4", "d");
            dic.Add("5", "e");
            Console.WriteLine($"{dic["1"]},{dic["2"]}");
        }
        public void MainFunc()
        {
            //  Func_ListTest();
            Func_DictionaryTest();
        }

    }
}

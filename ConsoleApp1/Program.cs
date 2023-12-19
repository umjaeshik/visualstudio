using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace ConsoleApp1
{
    static class myLib
    {
        public static string GetToken(string str, int n, char ch)  //str: " 1 2 3 " "1, 2, 3", (n)번째, ',' ' '
        {
            return str.Split(ch)[n];
        }
    }

    class Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Dist1(Point p1, Point p2)
        {
            
                return Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
            
        }
        public static double operator - (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
        }
        public static int operator *(Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return d1*d2;
        }
    }
    

    internal class Program
    {
        public void Func1()
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            double distance = p2.Dist1(p2, p1);
            WriteLine("두 점 p1, p2의 거리는 {0}",distance);
            WriteLine("두 점 p1, p2의 거리는 {0}", p2-p1);
            WriteLine("두 점 p1, p2의 사각형의 넓이는 {0}", p2 * p1);

        }
        public static void Main(string[] args)
        {
            Program a = new Program();
            a.Func1();
            
        }
    }
}

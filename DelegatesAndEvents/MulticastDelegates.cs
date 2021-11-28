using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public delegate void MultiDel(int x, int y);
    public class MulticastDelegates
    {
        public static void ImplementDelegate()
        {
            MultiDel obj = Operation.Add;
            obj += Operation.Multiply;
            obj(9, 4);
            obj(1, 6);
        }
        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition is = {0}", a + b);
            }
            public static void Multiply(int a, int b)
            {
                Console.WriteLine("Multiplication is = {0}", a * b);
            }
        }
    }
}
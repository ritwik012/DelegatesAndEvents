using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public delegate void DelEventHandler();
    public class Events
    {
        public static event DelEventHandler add;
        public static void ImplementEvent()
        {
            add += new DelEventHandler(India);
            add += new DelEventHandler(USA);
            add += new DelEventHandler(England);
            add.Invoke();
        }
        private static void India()
        {
            Console.WriteLine("India");
        }
        private static void USA()
        {
            Console.WriteLine("USA");
        }
        private static void England()
        {
            Console.WriteLine("England");
        }
    }
}
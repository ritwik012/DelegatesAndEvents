using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Programs");
            operation obj = new operation(SinglecastDelegates.Addition);
            Console.WriteLine("Addition is = {0}", obj(91, 47));
            Console.WriteLine();
            MulticastDelegates.ImplementDelegate();
            Events.ImplementEvent();
        }
    }
}
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldObj = new OldObj();
            var target = new Adapter(oldObj);

            Console.WriteLine(target.GetRequest());
        }
    }
}
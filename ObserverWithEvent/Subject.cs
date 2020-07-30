using System;
using System.Threading;

namespace ObserverWithEvent
{
    public class Subject
    {
        public delegate void State(int state);

        public event State Notify;

        public State StateDelegate;

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important");
            var state = new Random().Next(0, 10);
            Thread.Sleep(15);
            Console.WriteLine($"Subject: My state just changed to: {state}");
            Notify?.Invoke(state);
            StateDelegate(state);
        }
    }
}
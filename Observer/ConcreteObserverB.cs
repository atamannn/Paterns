using System;

namespace Observer
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State > 5)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event");
            }
        }
    }
}